using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistry
{
    public class Cars
    {
        //test 
        //123
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int CarYear { get; set; }
        public int LastCarInspection { get; set; }
        public string LicensePlateNumber { get; set; }
        public bool IsElectric { get; set; }

        public static List<Cars> cars = new List<Cars>();

        public Cars(string brand, string model, string color, int carYear, int lastCarInspection, string licensePlateNumber, bool isElectric)
        {
            Brand = brand;
            Model = model;
            Color = color;
            CarYear = carYear;
            LastCarInspection = lastCarInspection;
            LicensePlateNumber = licensePlateNumber;
            IsElectric = isElectric;
        }

        public string GetInfo()
        {
            return "Brand: " + Brand + ", Model: " + Model + ", Color: " + Color + ",Car year: " + CarYear + ", Last car inspection: " + LastCarInspection + ", License plate number: " + LicensePlateNumber + ", Is Electric " + IsElectric;
        }
        public string GetCSV()
        {
            return Brand + "," + Model + "," + Color + "," + LicensePlateNumber + "," + IsElectric;
        }
    }
}
