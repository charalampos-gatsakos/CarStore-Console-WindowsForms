using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Brand = "Nothing yet";
            Model = "Nothing yet";
            Price = 0.00M;
        }
        public Car(string a,string b, decimal c)
        {
            Brand = a;
            Model = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Make:" + Brand + "Model" + Model + "Price: $" + Price;
        }

    }
}
