// Author:          Rohail Shah
// Last Modified:   March 13, 2021
// Description:
//  Using an existing Car class, this
//  Windows form can display a list of cars and allow the user
//  to add new cars to the list as well as edit existing cars
//  selected from a ListView.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class formCarInventory : Form
    {
        private List<Cars> carList = new List<Cars>();
        // This flag is used to indicate whether the program is checking boxes as opposed to a human.
        private bool isAutomated = false;
        // Variable representing the current selected index in the ListView.
        // This is being used to simplify a few reference to indexes.
        private int selectedIndex = -1;

        // Variable that holds ID number of cars being added.
        int carIDCount = 3;

        public formCarInventory()
        {
            InitializeComponent();
        }

        #region "Event Handlers"

        /// <summary>
        /// When the form loads, instantiate some cars and add them to a list so they can be viewed later.
        /// </summary>
        private void formCarInventory_Load(object sender, EventArgs e)
        {
            // Declare and instantiate new car objects.
            // You are going to be asked to change some of these values.
            Cars mine = new Cars(1, "Nissan", "Rogue", 2013, 12000, false);
            Cars tesla = new Cars(2, "Tesla", "Model S", 2021, 114990, true);
            Cars bugatti = new Cars(3, "Bugatti", "La Voiture Noire", 2021, 18700000, true);

            // Add all of the new car objects from above to the list.
            carList.Add(mine);
            carList.Add(tesla);
            carList.Add(bugatti);

            PopulateListView(carList);
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Validate all input fields, and if they are valid create the car object, add the entered car to the list, and add them to the ListView.
        /// </summary>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Empty the error label; it will fill with NEW errors if anything is wrong.
            labelError.Text = String.Empty;
            // Increment ID by 1 for every new car being added.
            carIDCount += 1;

            // Check if the car is valid.
            if (IsCarValid(comboBoxMake.Text, textBoxModel.Text, comboBoxYear.Text, textBoxPrice.Text))
            {
                // Car details are valid; create a car object.
                Cars newCarToAdd = new Cars(carIDCount, comboBoxMake.Text, textBoxModel.Text, int.Parse(comboBoxYear.Text), decimal.Parse(textBoxPrice.Text), checkBoxNew.Checked);

                // If a car is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that car with the new one!
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    // Otherwise, add a car with the entered details to the end of the list.
                    carList.Add(newCarToAdd);
                }

                // Refresh the entire listView.
                PopulateListView(carList);

                // Reset the form to allow new entries.
                SetDefaults();
            }
        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// When a car in the ListView is selected, write that car's properties into the input controls.
        /// </summary>
        private void CarSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // If the list is populated and something is selected...
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected car.
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                comboBoxYear.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[5].Text;
                checkBoxNew.Checked = listViewEntries.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewEntries.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        #endregion

        #region "Functions"

        /// <summary>
        /// Converts the car passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="newCar"></param>
        private void PopulateListView(List<Cars> carList)
        {
            // Clear the listView to start re-populating it.
            listViewEntries.Items.Clear();

            foreach (Cars newCar in carList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem carItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;
                carItem.Checked = newCar.NewStatus;

                carItem.SubItems.Add(newCar.Id.ToString());
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(newCar.Year.ToString());
                carItem.SubItems.Add(newCar.Price.ToString());

                // Add the carItem to the ListView.
                listViewEntries.Items.Add(carItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        /// <summary>
        /// Reset the form's input fields to their default states.
        /// </summary>
        private void SetDefaults()
        {
            // Resets fields to default state.
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBoxYear.SelectedIndex = -1;
            textBoxPrice.Clear();
            checkBoxNew.Checked = false;
            listViewEntries.SelectedItems.Clear();
            labelError.Text = String.Empty;
            selectedIndex = -1;

            // Set a default focus.
            comboBoxMake.Focus();
        }

        /// <summary>
        /// Checks whether the input related to a car is valid.
        /// </summary>
        /// <param name="make">The car's make as a string</param>
        /// <param name="model">The car's model as a string</param>
        /// <param name="year">The car's year as an integer</param>
        /// <param name="price">The car's price as a decimal</param>
        /// <returns></returns>
        private bool IsCarValid(string make, string model, string year, string price)
        {
            // Assume the car is valid.
            bool isValid = true;

            // Check the first input.
            if (make == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must select a make.\n";
            }
            // Check the second input.
            if (model == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must enter a model.\n";
            }
            //Check the third input for blanks.
            if (year == String.Empty)
            {
                //If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must select a year.\n";
            }
            //Check the third input for integer values or not.
            int rightYear;
            if (int.TryParse(price, out rightYear))
            {
                if (rightYear < 0)
                {
                    isValid &= false;
                    labelError.Text += "The year must be a positive value.\n";
                }
            }
            else
            {
                isValid &= false;
                labelError.Text += "The year must be entered as a number.\n";
            }
            //Check the fourth input for blanks.
            if (price == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must enter a price.\n";
            }
            //Check the fourth input for decimal values or not.
            double rightPrice;
            if (double.TryParse(price, out rightPrice))
            {
                if (rightPrice < 0)
                {
                    isValid &= false;
                    labelError.Text += "The price must be a positive value.\n";
                }
            }
            else
            {
                isValid &= false;
                labelError.Text += "The price must be entered as a number.\n";
            }

            return isValid;
        }

        #endregion
        
    }
}
