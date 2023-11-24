namespace CarRegistry
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchVehiclesLabel = new System.Windows.Forms.Label();
            this.searchVihiclesButtonis = new System.Windows.Forms.Button();
            this.searchVehiclesTextBoxis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inspectionYearComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.carYearComboBox = new System.Windows.Forms.ComboBox();
            this.lastCarInspectionLabel = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.isElectricCheckBox = new System.Windows.Forms.CheckBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCarsButton = new System.Windows.Forms.Button();
            this.licancePlatetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CarsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.searchVehiclesLabel);
            this.tabPage1.Controls.Add(this.searchVihiclesButtonis);
            this.tabPage1.Controls.Add(this.searchVehiclesTextBoxis);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search vehicles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchVehiclesLabel
            // 
            this.searchVehiclesLabel.AutoSize = true;
            this.searchVehiclesLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchVehiclesLabel.Location = new System.Drawing.Point(9, 19);
            this.searchVehiclesLabel.Name = "searchVehiclesLabel";
            this.searchVehiclesLabel.Size = new System.Drawing.Size(213, 46);
            this.searchVehiclesLabel.TabIndex = 6;
            this.searchVehiclesLabel.Text = "Car Registry";
            // 
            // searchVihiclesButtonis
            // 
            this.searchVihiclesButtonis.Location = new System.Drawing.Point(240, 117);
            this.searchVihiclesButtonis.Name = "searchVihiclesButtonis";
            this.searchVihiclesButtonis.Size = new System.Drawing.Size(199, 23);
            this.searchVihiclesButtonis.TabIndex = 9;
            this.searchVihiclesButtonis.Text = "Search";
            this.searchVihiclesButtonis.UseVisualStyleBackColor = true;
            this.searchVihiclesButtonis.Click += new System.EventHandler(this.searchVihiclesButtonis_Click_1);
            // 
            // searchVehiclesTextBoxis
            // 
            this.searchVehiclesTextBoxis.Location = new System.Drawing.Point(240, 88);
            this.searchVehiclesTextBoxis.Name = "searchVehiclesTextBoxis";
            this.searchVehiclesTextBoxis.Size = new System.Drawing.Size(199, 23);
            this.searchVehiclesTextBoxis.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "License plate number:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.inspectionYearComboBox);
            this.tabPage2.Controls.Add(this.saveButton);
            this.tabPage2.Controls.Add(this.carYearComboBox);
            this.tabPage2.Controls.Add(this.lastCarInspectionLabel);
            this.tabPage2.Controls.Add(this.carYearLabel);
            this.tabPage2.Controls.Add(this.isElectricCheckBox);
            this.tabPage2.Controls.Add(this.addCarButton);
            this.tabPage2.Controls.Add(this.licensePlateNumberLabel);
            this.tabPage2.Controls.Add(this.colorLabel);
            this.tabPage2.Controls.Add(this.carModelLabel);
            this.tabPage2.Controls.Add(this.brandLabel);
            this.tabPage2.Controls.Add(this.licensePlateNumberTextBox);
            this.tabPage2.Controls.Add(this.carModelTextBox);
            this.tabPage2.Controls.Add(this.carColorTextBox);
            this.tabPage2.Controls.Add(this.carBrandTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add a vehicle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inspectionYearComboBox
            // 
            this.inspectionYearComboBox.FormattingEnabled = true;
            this.inspectionYearComboBox.Location = new System.Drawing.Point(263, 196);
            this.inspectionYearComboBox.Name = "inspectionYearComboBox";
            this.inspectionYearComboBox.Size = new System.Drawing.Size(200, 23);
            this.inspectionYearComboBox.TabIndex = 57;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(395, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 40);
            this.saveButton.TabIndex = 56;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // carYearComboBox
            // 
            this.carYearComboBox.FormattingEnabled = true;
            this.carYearComboBox.Location = new System.Drawing.Point(263, 152);
            this.carYearComboBox.Name = "carYearComboBox";
            this.carYearComboBox.Size = new System.Drawing.Size(200, 23);
            this.carYearComboBox.TabIndex = 55;
            // 
            // lastCarInspectionLabel
            // 
            this.lastCarInspectionLabel.AutoSize = true;
            this.lastCarInspectionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastCarInspectionLabel.Location = new System.Drawing.Point(13, 190);
            this.lastCarInspectionLabel.Name = "lastCarInspectionLabel";
            this.lastCarInspectionLabel.Size = new System.Drawing.Size(220, 28);
            this.lastCarInspectionLabel.TabIndex = 54;
            this.lastCarInspectionLabel.Text = "Last car inspection date:";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carYearLabel.Location = new System.Drawing.Point(23, 152);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(87, 28);
            this.carYearLabel.TabIndex = 53;
            this.carYearLabel.Text = "Car year:";
            // 
            // isElectricCheckBox
            // 
            this.isElectricCheckBox.AutoSize = true;
            this.isElectricCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isElectricCheckBox.Location = new System.Drawing.Point(13, 276);
            this.isElectricCheckBox.Name = "isElectricCheckBox";
            this.isElectricCheckBox.Size = new System.Drawing.Size(111, 32);
            this.isElectricCheckBox.TabIndex = 52;
            this.isElectricCheckBox.Text = "Is Electric";
            this.isElectricCheckBox.UseVisualStyleBackColor = true;
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(258, 301);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(108, 40);
            this.addCarButton.TabIndex = 51;
            this.addCarButton.Text = "Add car";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click_1);
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(16, 232);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(200, 28);
            this.licensePlateNumberLabel.TabIndex = 50;
            this.licensePlateNumberLabel.Text = "License plate number:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorLabel.Location = new System.Drawing.Point(23, 106);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(95, 28);
            this.colorLabel.TabIndex = 49;
            this.colorLabel.Text = "Car color:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carModelLabel.Location = new System.Drawing.Point(23, 58);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(106, 28);
            this.carModelLabel.TabIndex = 48;
            this.carModelLabel.Text = "Car model:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandLabel.Location = new System.Drawing.Point(23, 17);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(102, 28);
            this.brandLabel.TabIndex = 47;
            this.brandLabel.Text = "Car brand:";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(263, 239);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(200, 23);
            this.licensePlateNumberTextBox.TabIndex = 46;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(263, 58);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(200, 23);
            this.carModelTextBox.TabIndex = 45;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Location = new System.Drawing.Point(263, 106);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.Size = new System.Drawing.Size(200, 23);
            this.carColorTextBox.TabIndex = 44;
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(263, 17);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(200, 23);
            this.carBrandTextBox.TabIndex = 43;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.SearchCarsButton);
            this.tabPage3.Controls.Add(this.licancePlatetextBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1050, 586);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit vehicles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edit already existing cars";
            // 
            // SearchCarsButton
            // 
            this.SearchCarsButton.Location = new System.Drawing.Point(240, 121);
            this.SearchCarsButton.Name = "SearchCarsButton";
            this.SearchCarsButton.Size = new System.Drawing.Size(199, 23);
            this.SearchCarsButton.TabIndex = 13;
            this.SearchCarsButton.Text = "Search";
            this.SearchCarsButton.UseVisualStyleBackColor = true;
            this.SearchCarsButton.Click += new System.EventHandler(this.SearchCarsButton_Click_1);
            // 
            // licancePlatetextBox
            // 
            this.licancePlatetextBox.Location = new System.Drawing.Point(240, 92);
            this.licancePlatetextBox.Name = "licancePlatetextBox";
            this.licancePlatetextBox.Size = new System.Drawing.Size(199, 23);
            this.licancePlatetextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "License plate number:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.CarsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1050, 586);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View vehicles";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 61);
            this.button1.TabIndex = 41;
            this.button1.Text = "View Cars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CarsListBox
            // 
            this.CarsListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarsListBox.FormattingEnabled = true;
            this.CarsListBox.Location = new System.Drawing.Point(89, 27);
            this.CarsListBox.Name = "CarsListBox";
            this.CarsListBox.Size = new System.Drawing.Size(792, 199);
            this.CarsListBox.TabIndex = 40;
            this.CarsListBox.SelectedIndexChanged += new System.EventHandler(this.CarsListBox_SelectedIndexChanged_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainMenu";
            this.Text = "CarRegistry";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label searchVehiclesLabel;
        private Button searchVihiclesButtonis;
        private TextBox searchVehiclesTextBoxis;
        private Label label1;
        private TabPage tabPage2;
        private ComboBox inspectionYearComboBox;
        private Button saveButton;
        private ComboBox carYearComboBox;
        private Label lastCarInspectionLabel;
        private Label carYearLabel;
        private CheckBox isElectricCheckBox;
        private Button addCarButton;
        private Label licensePlateNumberLabel;
        private Label colorLabel;
        private Label carModelLabel;
        private Label brandLabel;
        private TextBox licensePlateNumberTextBox;
        private TextBox carModelTextBox;
        private TextBox carColorTextBox;
        private TextBox carBrandTextBox;
        private TabPage tabPage3;
        private Label label2;
        private Button SearchCarsButton;
        private TextBox licancePlatetextBox;
        private Label label3;
        private TabPage tabPage4;
        private Button button1;
        private ListBox CarsListBox;
    }
}