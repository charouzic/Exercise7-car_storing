using System;

namespace exercise7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Processor carApplication = new Processor();

            Console.WriteLine("Exercise 7");

            Console.WriteLine("\n**** Welcome to the CarX app ****");
            carApplication.AuthenticateUser();
        }
    }
}


/*
Exercise 07


Create a new app for a car dealer in Gotham City. The dealer is named CarX . 
Store owner wants to use app to perform following functions:
1) Store list of all cars in stock
2) Function to view List of cars
3) Add a new car

Please note that the app features should only be visible if the user knows correct username and password. 


A car can have following properties:
        RegNr, ChassisNr, Price, Brand, YearBuilt, ModelVariant
Car has two types
• Electric Car >> (Battery Volt, Charge Time, Km per Charge)
• Fuel Car >> Fuel car can be Benzin or Diesel (Tank size, Km per Ltr)


Questions:

Q1) Build the app for CarX that prompts Login at start.

02) If a correct (hard coded) username and password in inserted then the app should give access to the functions:
a) Store list of all cars in stock
b) Function to view List of cars
c) Add a new car
q) Quit

03) Use inheritance to create base and derived classes to store car information.

04) Use enum whereever appropriate to store certain data values. For example: FuelType.

05) Use a Processor Class to build functions like ShowAppFeatures (to print menu options) and AuthenticareUser(to authenticate login).

06) Implement functions in appropriate class to perform tasks a,b,c. Hint: Use ArrayList to store Cars.

*/