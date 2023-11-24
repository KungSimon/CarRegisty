using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRegistry
{
    public partial class Vehicle : Form
    {
        public Vehicle(Cars car)
        {
            InitializeComponent();
            carBrandTextBox.Text = car.Brand;
            carBrandTextBox.ReadOnly = true;
            carModelTextBox.Text = car.Model;
            carModelTextBox.ReadOnly = true;
            carColorTextBox.Text = car.Color;
            carColorTextBox.ReadOnly = true;
            carYearComboBox.Text = car.CarYear.ToString();
            comboBox1.Text = car.LastCarInspection.ToString();
            licensePlateNumberTextBox.Text = car.LicensePlateNumber;
            licensePlateNumberTextBox.ReadOnly = true;
            isElectricCheckBox.Checked = car.IsElectric;
            isElectricCheckBox.Enabled = false;
        }
    }
}
