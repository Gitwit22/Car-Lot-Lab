using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot_Lab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Mileage: {Mileage:N0} miles";
        }
    }


}
