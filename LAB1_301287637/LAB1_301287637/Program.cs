using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2018, "BMW", "525M", 53300);
            Console.WriteLine(car1.ToString());
            Car car2 = new Car(2019, "Toyota", "RAV4", 33700, true);
            Console.WriteLine(car2.ToString());
            Car car3 = new Car(2021, "Ferrari", "SF90", 375000, true);
            Console.WriteLine(car3.ToString());
            Car car4 = new Car(2012, "Ford", "Focus", 25500, false);
            Console.WriteLine(car4.ToString());
        }
    }

    class Car
    {
        int yeaR;
        string manufactureR;
        string modeL;
        bool isDrivablE;
        double pricE;

        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            yeaR = year;
            manufactureR = manufacturer;
            modeL = model;
            pricE = price;
            isDrivablE = isDrivable;
        }

        public override string ToString()
        {
            string info;
            if (isDrivablE)
            {
                info = $"The car {modeL} was created by {manufactureR} at a price {pricE:c} in a year {yeaR} is on the move!";
            }
            else
            {
                info = $"The car {modeL} was created by {manufactureR} at a price {pricE:c} in a year {yeaR} is not on the move!";
            }
            return info;
        }
    }
}

