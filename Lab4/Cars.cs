// Cars.cs
// Author:  Rohail
// Date:    March 13, 2021
// Description:
//  A class designed to keep a record of individual cars,
//  including a little information that describes their importance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// A class designed to keep a record of individual cars, including a little information that describes their importance.
    /// </summary>
    class Cars
    {
        // Static private variable to hold the number of customers.
        private static int carCount = 0;
        // Private variable to hold the customer's identification number.
        private int carID = 0;
        // Private variable to hold the customer's title.
        private string carMake = String.Empty;
        // Private variable to hold the customer's first name.
        private string carModel = String.Empty;
        // Private variable to hold the customer's last name.
        private int carYear = 0;
        // Private variable to hold the customer's last name.
        private decimal carPrice = 0;
        // Private variable to hold the customer's status.
        private bool carNewStatus = false;

        /// <summary>
        /// Constructor - Default - creates a new car object.
        /// </summary>
        public Cars()
        {
            carCount += 1;
            carID = carCount;
        }

        /// <summary>
        /// Constructor - Parameterized - creates a new car object
        /// </summary>
        /// <param name="make">Car's make</param>
        /// <param name="model">Car's model</param>
        /// <param name="year">Car's year</param>
        /// <param name="price">Car's price</param>
        /// <param name="newStatus">True if a car is new</param>
        public Cars(int ID, string make, string model, int year, decimal price, bool newStatus) : this()
        {
            // The ": this()" part above calls the default constructor, setting the Id.

            // Set all of the instance variables within this class using the values
            // passed into this constructor.
            carID = ID;
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            carNewStatus = newStatus;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of cars that have been instantiated/created
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets a specific cars' identification number
        /// </summary>
        public int Id
        {
            get
            {
                return carID;
            }
        }

        /// <summary>
        /// NewCarStatus Property - Gets and Sets the New status of a car
        /// </summary>
        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                carNewStatus = value;
            }
        }

        /// <summary>
        /// Make property - Gets and Sets the make of a car
        /// </summary>
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                // The value passed in is always called "value" by default - regardless of the data type.
                carMake = value;
            }
        }

        /// <summary>
        /// Model property - Gets and Sets the model of a car
        /// </summary>
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Year property - Gets and Sets the year of a car
        /// </summary>
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }

        /// <summary>
        /// Price property - Gets and Sets the price of a car
        /// </summary>
        public decimal Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }

        /// <summary>
        /// GetSalutation is a function that a salutation based on the private properties within the class scope
        /// </summary>
        /// <returns>string describing the customer</returns>
        public string GetSalutation()
        {
            return "Hi, my name is " + carMake + " " + carModel + " " + carYear + ", " + carPrice + ", " + (carNewStatus ? "I am NEW" : "I am not NEW");

            // The single line of code above is equivalent to the following eight lines of code:
            //if (customerVipStatus)
            //{
            //    return "Hi, my name is " + customerTitle + " " + customerFirstName + " " + customerLastName + ", I am a VIP";
            //}
            //else
            //{
            //    return "Hi, my name is " + customerTitle + " " + customerFirstName + " " + customerLastName + ", I am not a VIP";
            //}
        }
    }
}
