using System;
using System.Text;

namespace exercise7
{
    public class Car
    {
        /*
        public enum FFuelType
        {
            Electric = 0, Diesel = 1, Benzin = 2
        }
        */

        // this  is constructor - the class cannot be called without the parameters that are bellow
        public Car(int RegNr, int  ChassisNr, int Price, string Brand, string Model)
        {
            RegistrationNumber = RegNr;
            ChassisNumber = ChassisNr;
            CarPrice = Price;
            CarBrand = Brand;
            CarModel = Model;
            //CarFuelType = FuelType;
        }

        public int RegistrationNumber { get; set; }
        public int ChassisNumber { get; set; }
        public int CarPrice { get; set; }
        public string CarBrand { get; set; }
        public int CarYearBuilt { get; set; }
        public string CarModel { get; set; }
        //public FFuelType CarFuelType { get; set; }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.AppendLine("*** Printing out the car details ***");
            textOutput.AppendLine($"Brand: {CarBrand}");
            textOutput.AppendLine($"Model: {CarModel}");
            textOutput.AppendLine($"Registration Number: {RegistrationNumber}");
            textOutput.AppendLine($"Chassis Number: {ChassisNumber}");
            textOutput.AppendLine($"Car Price: {CarPrice}");

            return textOutput.ToString();
        }

    }
}
