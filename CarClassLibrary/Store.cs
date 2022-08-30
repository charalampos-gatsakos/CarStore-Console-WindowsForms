using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            //initialize the total cost
            decimal totalcost = 0;

            foreach(var c in ShoppingList)
            {
                totalcost += c.Price;
            }
            ShoppingList.Clear();

            return totalcost;
        }
    }
}
