using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_oop
{

    public class AditionalDetails
    {
        public string GearBox;
        public double Weigh;
        public string SeatsNumber;

        public AditionalDetails(string gearBox, double weigh, string seatsNumber)
        {
            GearBox = gearBox;
            Weigh = weigh;
            SeatsNumber = seatsNumber;
        }
    }

    internal class Car : AditionalDetails
    {
        public DateOnly Year;
        public string Type;
        public double Price;
        public string Model;
        public string PalletNo;
        public string Color;
        public double Tempreture;

        public Car(DateOnly year, string type, double price, string model, string palletNo, string color, double temp, string gearBox, double weigh, string seatsNumber): base(gearBox, weigh, seatsNumber)
        {
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
            Tempreture = temp;
        }

        public string Engine(double temp)
        {
            if (Tempreture < 50)
            {
                return "Start Engine";
            }
            else
            {
                return "Stop Engine";
            }
        }
    }
}
  