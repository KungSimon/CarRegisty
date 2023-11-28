namespace CarRegistry
{
    public partial class MainMenu : Form
    {
        List<Cars> carList = new List<Cars>();
        string path = "car.csv";
        public MainMenu()
        {
            InitializeComponent();
            InitCarList();
        }
        private void InitCarList()
        {
            carList.Add(new Cars("Volvo", "XC90", "Black", 2022, 2022, "UFP 903", false));
            carList.Add(new Cars("Volvo", "V60", "White", 2023, 2022, "GHD 306", false));
            carList.Add(new Cars("BMW", "I8", "Grey", 2020, 2022, "HEJ 123", true));
            carList.Add(new Cars("Mercedes", "G-Wagon", "Black", 2018, 2022, "BOL 220", false));

            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                carYearComboBox.Items.Add(year.ToString());
                inspectionYearComboBox.Items.Add(year.ToString());
            }


        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CarsListBox.SelectedIndex;
            if (index >= 0)
            {
                carBrandTextBox.Text = carList[index].Brand;
                carModelTextBox.Text = carList[index].Model;
                carColorTextBox.Text = carList[index].Color;
                carYearComboBox.SelectedItem = carList[index].CarYear;
                inspectionYearComboBox.SelectedItem = carList[index].LastCarInspection;
                licancePlatetextBox.Text = carList[index].LicensePlateNumber;
                isElectricCheckBox.Checked = carList[index].IsElectric;
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Cars car in carList)
                    {
                        string csvLine = $"{car.Brand},{car.Model},{car.Color},{car.CarYear},{car.LastCarInspection},{car.LicensePlateNumber},{car.IsElectric}";
                        writer.WriteLine(csvLine);
                    }
                }
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Cars car in carList)
                {
                    writer.WriteLine(car.GetCSV());
                }
            }*/
        }
        private void LoadDataFromFile()
        {
            try
            {
                carList.Clear();
                CarsListBox.Items.Clear();

                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            try
                            {
                                string[] strings = line.Split(",");

                                string Brand = strings[0];
                                string Model = strings[1];
                                string Color = strings[2];
                                int Year = Convert.ToInt32(strings[3]);
                                int LastInspectionDate = Convert.ToInt32(strings[4]);
                                string licensePlateNumber = strings[5];
                                bool electricCar = Convert.ToBoolean(strings[6]);

                                Cars cars = new Cars(Brand, Model, Color, Year, LastInspectionDate, licensePlateNumber, electricCar);
                                carList.Add(cars);
                                CarsListBox.Items.Add(cars.GetInfo());

                                line = reader.ReadLine();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*carList.Clear();
            listBox.Items.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            string[] strings = line.Split(",");

                            string Brand = strings[0];
                            string Model = strings[1];
                            string Color = strings[2];
                            int Year = Convert.ToInt32(strings[3]);
                            int LastInspectionDate = Convert.ToInt32(strings[4]);
                            string licensePlateNumber = strings[5];
                            bool electricCar = bool.Parse(strings[6]);

                            Cars cars = new Cars(Brand, Model, Color, Year, LastInspectionDate, licensePlateNumber, electricCar);
                            carList.Add(cars);
                            listBox.Items.Add(cars.Brand);

                            line = reader.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }*/
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars(carBrandTextBox.Text, carModelTextBox.Text, carColorTextBox.Text, Convert.ToInt32(carYearComboBox.SelectedItem), Convert.ToInt32(inspectionYearComboBox.SelectedItem), licensePlateNumberTextBox.Text, isElectricCheckBox.Checked);
            carList.Add(cars);
            CarsListBox.Items.Add(cars.GetInfo());
            CarsListBox.Items.Add(string.Empty);
            
        }

        private void SearchCarsButton_Click(object sender, EventArgs e)
        {
            string searchTerm = licancePlatetextBox.Text.Trim(); // Ta bort eventuella extra mellanslag

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Sök igenom carList efter en bil med matchande LicensePlateNumber
                Cars foundCar = carList.FirstOrDefault(car => car.LicensePlateNumber == searchTerm);

                if (foundCar != null)
                {
                    EditCars editCar = new EditCars(foundCar);
                    editCar.Show();
                }
                else
                {
                    MessageBox.Show("No car matched your search.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            searchVehiclesTextBoxis.Clear();
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }
        private void searchVihiclesButtonis_Click_1(object sender, EventArgs e)
        {
            string searchTerm = searchVehiclesTextBoxis.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                Cars foundCar = carList.FirstOrDefault(car => car.LicensePlateNumber == searchTerm);

                if (foundCar != null)
                {
                    Vehicle vehicle = new Vehicle(foundCar);
                    vehicle.Show();

                }
                else
                {
                    MessageBox.Show("No car matched your search.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            searchVehiclesTextBoxis.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                carList.Clear();
                CarsListBox.Items.Clear();

                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            try
                            {
                                string[] strings = line.Split(",");

                                string Brand = strings[0];
                                string Model = strings[1];
                                string Color = strings[2];
                                int Year = Convert.ToInt32(strings[3]);
                                int LastInspectionDate = Convert.ToInt32(strings[4]);
                                string licensePlateNumber = strings[5];
                                bool electricCar = Convert.ToBoolean(strings[6]);

                                Cars cars = new Cars(Brand, Model, Color, Year, LastInspectionDate, licensePlateNumber, electricCar);
                                carList.Add(cars);
                                CarsListBox.Items.Add(cars.GetInfo());

                                line = reader.ReadLine();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = CarsListBox.SelectedIndex;
            if (index >= 0)
            {
                carBrandTextBox.Text = carList[index].Brand;
                carModelTextBox.Text = carList[index].Model;
                carColorTextBox.Text = carList[index].Color;
                carYearComboBox.SelectedItem = carList[index].CarYear;
                inspectionYearComboBox.SelectedItem = carList[index].LastCarInspection;
                licancePlatetextBox.Text = carList[index].LicensePlateNumber;
                isElectricCheckBox.Checked = carList[index].IsElectric;
            }
        }

        private void addCarButton_Click_1(object sender, EventArgs e)
        {
            Cars cars = new Cars(carBrandTextBox.Text, carModelTextBox.Text, carColorTextBox.Text, Convert.ToInt32(carYearComboBox.SelectedItem), Convert.ToInt32(inspectionYearComboBox.SelectedItem), licensePlateNumberTextBox.Text, isElectricCheckBox.Checked);
            carList.Add(cars);
            CarsListBox.Items.Add(cars.GetInfo());
            CarsListBox.Items.Add(string.Empty);
            carBrandTextBox.Text = "";
            carModelTextBox.Text = "";
            carColorTextBox.Text = "";
            carYearComboBox.ResetText();
            inspectionYearComboBox.ResetText();
            licensePlateNumberTextBox.Text = "";
            isElectricCheckBox.Checked = false;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Cars car in carList)
                    {
                        string csvLine = $"{car.Brand},{car.Model},{car.Color},{car.CarYear},{car.LastCarInspection},{car.LicensePlateNumber},{car.IsElectric}";
                        writer.WriteLine(csvLine);
                    }
                }
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCarsButton_Click_1(object sender, EventArgs e)
        {
            string searchTerm = licancePlatetextBox.Text.Trim(); 

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Sök igenom carList efter en bil med matchande LicensePlateNumber
                Cars foundCar = carList.FirstOrDefault(car => car.LicensePlateNumber == searchTerm);

                if (foundCar != null)
                {
                    EditCars editCar = new EditCars(foundCar);
                    editCar.Show();
                }
                else
                {
                    MessageBox.Show("No car matched your search.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            searchVehiclesTextBoxis.Clear();
        }
    }
}