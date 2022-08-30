using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();

            while(action != 0)
            {
                Console.WriteLine("You chose" + action);
                switch (action)
                {
                    // add item to iventory
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");
                        String carBrand = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        Console.WriteLine("What is the car make ? , Ford ,GM , Nissan etc.");
                        carBrand = Console.ReadLine();
                        Console.WriteLine("What is the car model ? Corvette ,Focus , Ranger etc");
                        carModel = Console.ReadLine();
                        Console.WriteLine("What is the price ?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carBrand, carModel, carPrice);
                        s.CarList.Add(newCar);
                        printInventory(s);
                        break;

                    // add to cart
                    case 2:
                        Console.WriteLine("You choose to add a car to you");


                        break;
                }
                action = chooseAction();
            }
           
        }

        private static void printInventory(Store s)
        {
            foreach(Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c.Brand + " " + c.Model + " " + c.Price);
            }
        }

        static public int chooseAction()
            {
                int choice = 0;
                Console.WriteLine("Choose an action <0> to quit <1> to add a new car to inventory <2> add car to cart <3> checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
            }
    }
}
