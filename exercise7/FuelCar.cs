using System;
using System.Text;

namespace exercise7
{
    public class FuelCar : Car
    {
        public FuelCar(int RegNr, int ChassisNr, int Price, string Brand, string Model, int tankSize, int lPer100Km) : base (RegNr,ChassisNr,Price,Brand, Model)
        {
            TankSize = tankSize;
            LPer100Km = lPer100Km;
        }

        public int TankSize { get; set; }
        public int LPer100Km { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Tank Size: {TankSize}");
            str.AppendLine($"Liters per 100km: {LPer100Km}");
            return str.ToString();
        }
    }
}
