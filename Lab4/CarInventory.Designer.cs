
namespace Lab4
{
    partial class formCarInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeaderNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.Location = new System.Drawing.Point(79, 10);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(100, 23);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make:";
            this.labelMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Items.AddRange(new object[] {
            "Volkswagen",
            "Hyundai",
            "Nissan",
            "Tesla",
            "Bugatti"});
            this.comboBoxMake.Location = new System.Drawing.Point(185, 12);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMake.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxMake, "Select the car\'s make.");
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(79, 37);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(100, 23);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "M&odel:";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2010",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBoxYear.Location = new System.Drawing.Point(185, 65);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 5;
            this.toolTip.SetToolTip(this.comboBoxYear, "Select the car\'s year.");
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(185, 39);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(121, 20);
            this.textBoxModel.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxModel, "Enter the car\'s model.");
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(79, 63);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(100, 23);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year:";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(185, 92);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxPrice, "Enter the car\'s price.");
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(79, 90);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 23);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.AutoSize = true;
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Location = new System.Drawing.Point(148, 116);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(51, 17);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New:";
            this.toolTip.SetToolTip(this.checkBoxNew, "Select if the car is new.");
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // listViewEntries
            // 
            this.listViewEntries.CheckBoxes = true;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNew,
            this.columnHeaderID,
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderYear,
            this.columnHeaderPrice});
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(12, 141);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(360, 260);
            this.listViewEntries.TabIndex = 9;
            this.toolTip.SetToolTip(this.listViewEntries, "Display a list of all cars.");
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewEntries.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CarSelected);
            // 
            // columnHeaderNew
            // 
            this.columnHeaderNew.Text = "New";
            this.columnHeaderNew.Width = 35;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 35;
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Make";
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 95;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            // 
            // labelError
            // 
            this.labelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelError.Location = new System.Drawing.Point(12, 404);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(360, 100);
            this.labelError.TabIndex = 10;
            this.toolTip.SetToolTip(this.labelError, "Displays all error messages.");
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(297, 507);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(216, 507);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset all entry fields.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEnter.Location = new System.Drawing.Point(135, 507);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter / confirm changes on the current car.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // formCarInventory
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(384, 542);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.labelMake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.Load += new System.EventHandler(this.formCarInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ColumnHeader columnHeaderNew;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

