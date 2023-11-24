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
    public partial class EditCars : Form
    {
        private Cars editedCar;
        private string csvFilePath = "car.csv";
        // TEst bom
        public EditCars(Cars car)
        {
            InitializeComponent();
            editedCar = car;
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                carYearComboBox.Items.Add(year.ToString());
                inspectionYearComboBox.Items.Add(year.ToString());
            }

            carBrandTextBox.Text = car.Brand;
            carModelTextBox.Text = car.Model;
            carColorTextBox.Text = car.Color;
            carYearComboBox.Text = car.CarYear.ToString();
            inspectionYearComboBox.Text = car.LastCarInspection.ToString();
            licensePlateNumberTextBox.Text = car.LicensePlateNumber;
            isElectricCheckBox.Checked = car.IsElectric;
        }

        private void carBrandTextBox_TextChanged(object sender, EventArgs e)
        {


        }
        

        private void editCarButton_Click_1(object sender, EventArgs e)
        {
            editedCar.Brand = carBrandTextBox.Text;
            editedCar.Model = carModelTextBox.Text;
            editedCar.Color = carColorTextBox.Text;
            editedCar.LicensePlateNumber = licensePlateNumberTextBox.Text;

            if (int.TryParse(carYearComboBox.Text, out int carYear))
            {
                editedCar.CarYear = carYear;
            }
            else
            {
                MessageBox.Show("Invalid Car Year format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(inspectionYearComboBox.Text, out int inspectionYear))
            {
                editedCar.LastCarInspection = inspectionYear;
            }
            else
            {
                MessageBox.Show("Invalid Inspection Year format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editedCar.IsElectric = isElectricCheckBox.Checked;
            UpdateDataInCsvFile();
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void deleteCarButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteCarFromCsv();
                MessageBox.Show("Car deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void UpdateDataInCsvFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');

                    if (values.Length == 7 && values[5] == editedCar.LicensePlateNumber)
                    {
                        lines[i] = $"{editedCar.Brand},{editedCar.Model},{editedCar.Color},{editedCar.CarYear},{editedCar.LastCarInspection},{editedCar.LicensePlateNumber},{editedCar.IsElectric}";
                        break;
                    }
                }
                File.WriteAllLines(csvFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data in the CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DeleteCarFromCsv()
        {
            try
            {
                List<string> lines = File.ReadAllLines(csvFilePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] values = lines[i].Split(',');

                    if (values.Length == 7 && values[5] == editedCar.LicensePlateNumber)
                    {
                        lines.RemoveAt(i);
                        break;
                    }
                }

                File.WriteAllLines(csvFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data from the CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
