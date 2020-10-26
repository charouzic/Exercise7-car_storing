using System;
using System.Text;

namespace exercise7
{
    public class ElectricCar : Car
    {
        public ElectricCar(int RegNr, int ChassisNr, int Price, string Brand, string Model, int  batteryVoltage, int chargeTime, int kmPerCharge) : base(RegNr,ChassisNr,Price,Brand, Model)
        {
            BatteryVoltage = batteryVoltage;
            ChargeTime = chargeTime;
            KmPerCharge = kmPerCharge;
        }

        public int BatteryVoltage { get; set; }
        public int ChargeTime { get; set; }
        public int KmPerCharge { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Battery Voltage: {BatteryVoltage}");
            str.AppendLine($"Charge Time: {ChargeTime}");
            str.AppendLine($"Km per Charge: {KmPerCharge}");
            return str.ToString();
        }
    }

    
}
