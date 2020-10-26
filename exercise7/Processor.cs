using System;
using System.Collections;
using System.Collections.Generic;
namespace exercise7
{
    public class Processor
    {
        /*
        // this is constructor!
        public EmptyClass()
        {
        }
        */

        private string adminName = "admin";
        private string adminPwd = "Listen20";
        static List<Car> carList = new List<Car>();

        // login method checking the correct credentials
        public void AuthenticateUser()
        {
            while(true)
            {
                Console.Write("\nPlease provide username to access the CarsX system: ");
                string userName = Console.ReadLine();
                Console.Write("Please provide password: ");
                string pwd = Console.ReadLine();

                if ((userName == adminName) & (pwd == adminPwd))
                {
                    InitCarList();
                    ShowAppFeatures();
                }

                else
                {
                    Console.WriteLine("Incorrect username and/or password");
                }
            }
        }

        public void ShowAppFeatures()
        {
            Console.WriteLine("\nHere are your menu options:");
            Console.WriteLine("1) Add a new car");
            Console.WriteLine("2) View the List of cars");
            Console.WriteLine("3) Store a list of all cars in stock");

            SelectAppFeature();
        }

        private void SelectAppFeature()
        {
            int userOption = 0;

            while (userOption < 4)
            {
                Console.Write("\nChoose your option: ");
                userOption = int.Parse(Console.ReadLine());
                switch (userOption)
                {
                    case 1:
                        AddCar(carList);
                        break;

                    case 2:
                        ShowCars();
                        break;

                    case 3:
                        Console.WriteLine("This option should store a list of all cars in stock");
                        break;
                }
                Console.WriteLine("\nYou can choose another option");
                ShowAppFeatures();
            }
            
        }



        public void ShowCars()
        {
            foreach(object auto in carList)
            {
                Console.WriteLine(auto);
            }
        }

        // method filling list of cars with some values so it's not empty
        public static List<Car> InitCarList()
        {
            ElectricCar car1 = new ElectricCar(55, 1020, 10000, "Tesla", "Model X", 375, 10, 500);
            FuelCar car2 = new FuelCar(12, 1212, 20000, "Volvo", "S90", 80, 8);
            ElectricCar car3 = new ElectricCar(1010, 2222, 5000, "Toyota", "Yaris", 350, 15, 300);
            FuelCar car4 = new FuelCar(9983, 3343, 8000, "VW", "Passat", 60, 5);

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);

            return carList;

        }

        // method getting the input from user in order to store the car properly
        public static void AddCar(List<Car> carList)
        {
            Console.Write("Provide car's registration number: ");
            int NewRegNr = int.Parse(Console.ReadLine());

            Console.Write("Provide car's chassis number: ");
            int NewChassisNr = int.Parse(Console.ReadLine());

            Console.Write("Provide car's price: ");
            int NewPrice = int.Parse(Console.ReadLine());

            Console.Write("Provide car's brand: ");
            string NewBrand = Console.ReadLine();

            Console.Write("Provide car's model: ");
            string NewModel = Console.ReadLine();

            Console.Write("Provide car's fuel (0 = Electric, 1 = Diesel, 3 = Benzin: ");
            int NewFuelType = int.Parse(Console.ReadLine());

            switch (NewFuelType)
            {
                case 0:
                    Console.Write("Provide car's battery voltage: ");
                    int NewBatteryVoltage = int.Parse(Console.ReadLine());

                    Console.Write("Provide car's charge time in minutes: ");
                    int NewChargeTime = int.Parse(Console.ReadLine());

                    Console.Write("Provide car's km per Charge: ");
                    int NewKmPerCharge = int.Parse(Console.ReadLine());

                    ElectricCar newElecticCar = new ElectricCar(NewRegNr, NewChassisNr, NewPrice, NewBrand, NewModel, NewBatteryVoltage, NewChargeTime, NewKmPerCharge);
                    carList.Add(newElecticCar);

                    Console.WriteLine($"Your car '{NewBrand} {NewModel}' has been added to the list");
                    break;

                case 1:
                    Console.Write("Provide car's tank size in liters: ");
                    int NewDieselTankSize = int.Parse(Console.ReadLine());

                    Console.Write("Provide car's average fuel consumption (liters/100km): ");
                    int NewDieselLitersPer100Km = int.Parse(Console.ReadLine());

                    FuelCar NewDieselCar = new FuelCar(NewRegNr, NewChassisNr, NewPrice, NewBrand, NewModel, NewDieselTankSize, NewDieselLitersPer100Km);
                    carList.Add(NewDieselCar);

                    Console.WriteLine($"Your car '{NewBrand} {NewModel}' has been added to the list");
                    break;

                case 2:
                    Console.Write("Provide car's tank size in liters: ");
                    int NewBenzinTankSize = int.Parse(Console.ReadLine());

                    Console.Write("Provide car's average fuel consumption (liters/100km): ");
                    int NewBenzinLitersPer100Km = int.Parse(Console.ReadLine());

                    FuelCar NewBenzinCar = new FuelCar(NewRegNr, NewChassisNr, NewPrice, NewBrand, NewModel, NewBenzinTankSize, NewBenzinLitersPer100Km);
                    carList.Add(NewBenzinCar);

                    Console.WriteLine($"Your car '{NewBrand} {NewModel}' has been added to the list");
                    break;

                default:
                    Console.WriteLine("Unknown option");
                    break;
            }

        }


    }
}
