namespace CarRegistry
{
    partial class EditCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCars));
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.editCarButton = new System.Windows.Forms.Button();
            this.inspectionYearComboBox = new System.Windows.Forms.ComboBox();
            this.carYearComboBox = new System.Windows.Forms.ComboBox();
            this.lastCarInspectionLabel = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.isElectricCheckBox = new System.Windows.Forms.CheckBox();
            this.licensePlateNumberLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.licensePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(187, 245);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(185, 23);
            this.deleteCarButton.TabIndex = 85;
            this.deleteCarButton.Text = "Delete Car";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click_1);
            // 
            // editCarButton
            // 
            this.editCarButton.Location = new System.Drawing.Point(187, 216);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(185, 23);
            this.editCarButton.TabIndex = 84;
            this.editCarButton.Text = "Uppdate car information";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click_1);
            // 
            // inspectionYearComboBox
            // 
            this.inspectionYearComboBox.FormattingEnabled = true;
            this.inspectionYearComboBox.Location = new System.Drawing.Point(172, 140);
            this.inspectionYearComboBox.Name = "inspectionYearComboBox";
            this.inspectionYearComboBox.Size = new System.Drawing.Size(200, 23);
            this.inspectionYearComboBox.TabIndex = 83;
            // 
            // carYearComboBox
            // 
            this.carYearComboBox.FormattingEnabled = true;
            this.carYearComboBox.Location = new System.Drawing.Point(172, 111);
            this.carYearComboBox.Name = "carYearComboBox";
            this.carYearComboBox.Size = new System.Drawing.Size(200, 23);
            this.carYearComboBox.TabIndex = 82;
            // 
            // lastCarInspectionLabel
            // 
            this.lastCarInspectionLabel.AutoSize = true;
            this.lastCarInspectionLabel.Location = new System.Drawing.Point(20, 140);
            this.lastCarInspectionLabel.Name = "lastCarInspectionLabel";
            this.lastCarInspectionLabel.Size = new System.Drawing.Size(131, 15);
            this.lastCarInspectionLabel.TabIndex = 81;
            this.lastCarInspectionLabel.Text = "Last car inspection date";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Location = new System.Drawing.Point(34, 111);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(50, 15);
            this.carYearLabel.TabIndex = 80;
            this.carYearLabel.Text = "Car year";
            // 
            // isElectricCheckBox
            // 
            this.isElectricCheckBox.AutoSize = true;
            this.isElectricCheckBox.Location = new System.Drawing.Point(25, 216);
            this.isElectricCheckBox.Name = "isElectricCheckBox";
            this.isElectricCheckBox.Size = new System.Drawing.Size(75, 19);
            this.isElectricCheckBox.TabIndex = 79;
            this.isElectricCheckBox.Text = "Is Electric";
            this.isElectricCheckBox.UseVisualStyleBackColor = true;
            // 
            // licensePlateNumberLabel
            // 
            this.licensePlateNumberLabel.AutoSize = true;
            this.licensePlateNumberLabel.Location = new System.Drawing.Point(20, 180);
            this.licensePlateNumberLabel.Name = "licensePlateNumberLabel";
            this.licensePlateNumberLabel.Size = new System.Drawing.Size(120, 15);
            this.licensePlateNumberLabel.TabIndex = 78;
            this.licensePlateNumberLabel.Text = "License plate number";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(34, 81);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(55, 15);
            this.colorLabel.TabIndex = 77;
            this.colorLabel.Text = "Car color";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(34, 50);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(62, 15);
            this.carModelLabel.TabIndex = 76;
            this.carModelLabel.Text = "Car model";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(34, 20);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(59, 15);
            this.brandLabel.TabIndex = 75;
            this.brandLabel.Text = "Car brand";
            // 
            // licensePlateNumberTextBox
            // 
            this.licensePlateNumberTextBox.Location = new System.Drawing.Point(172, 177);
            this.licensePlateNumberTextBox.Name = "licensePlateNumberTextBox";
            this.licensePlateNumberTextBox.Size = new System.Drawing.Size(200, 23);
            this.licensePlateNumberTextBox.TabIndex = 74;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(172, 50);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(200, 23);
            this.carModelTextBox.TabIndex = 73;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Location = new System.Drawing.Point(172, 81);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.Size = new System.Drawing.Size(200, 23);
            this.carColorTextBox.TabIndex = 72;
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(172, 20);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(200, 23);
            this.carBrandTextBox.TabIndex = 71;
            // 
            // EditCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.inspectionYearComboBox);
            this.Controls.Add(this.carYearComboBox);
            this.Controls.Add(this.lastCarInspectionLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.isElectricCheckBox);
            this.Controls.Add(this.licensePlateNumberLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.licensePlateNumberTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.carColorTextBox);
            this.Controls.Add(this.carBrandTextBox);
            this.Name = "EditCars";
            this.Text = "EditCars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteCarButton;
        private Button editCarButton;
        private ComboBox inspectionYearComboBox;
        private ComboBox carYearComboBox;
        private Label lastCarInspectionLabel;
        private Label carYearLabel;
        private CheckBox isElectricCheckBox;
        private Label licensePlateNumberLabel;
        private Label colorLabel;
        private Label carModelLabel;
        private Label brandLabel;
        private TextBox licensePlateNumberTextBox;
        private TextBox carModelTextBox;
        private TextBox carColorTextBox;
        private TextBox carBrandTextBox;
    }
}