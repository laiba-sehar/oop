using System;
using System.Collections.Generic;

namespace coffeetask.BL
{
    class Coffeetask
    {

        public string shopName="U";
        public static List<MenuItem> menu = new List<MenuItem>();
        public static List<string> orders = new List<string>();

        public static void storeInList(MenuItem m)
        {
            menu.Add(m);
        }
        public static void viewCheapestItem()
        {
            int low1 = 10000;
            string low2 = " ";
            foreach (MenuItem m in menu)
            {
                if (m.price < low1)
                {
                    low1 = m.price;
                    low2 = m.name;
                }
            }
            Console.WriteLine("CHEAPEST ITEM: {0}" + low2 + " " + "PRICE: {1}" + low1);

        }


        public static void viewDrinkMenu()
        {
            foreach (MenuItem m in menu)
            {
                if (m.type.ToLower() == "drink")
                {
                    Console.WriteLine(m.name + " " + m.price);
                }
            }

        }
        public static void viewFoodMenu()
        {
            foreach (MenuItem m in menu)
            {
                if (m.type.ToLower() == "food")
                {
                    Console.WriteLine(m.name + " " + m.price);
                }
            }

        }
        public static double addOrder()
        {
            double total = 0;
            Console.WriteLine("Number of orders:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter item name you want to order:");
                string itemName = Console.ReadLine();
                orders.Add(itemName);
                bool flag = false;
                foreach (MenuItem m in menu)
                {
                    if (m.name == itemName)
                    {
                        Console.WriteLine("You have orderde :{0}", m.name);
                        Console.WriteLine("Price :{0}", m.price);
                        total = total + m.price;
                        flag = true;

                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("THIS ITEM IS CURRENTLY UNAVAILABLE");
                }
            }
            return total;


        }
        public static void viewOrderInList()

        {
            foreach (string i in orders)
            {
                Console.WriteLine(i);
            }
        }

        public static void fulfillOrder()
        {
            
            if(orders != null)
            {
                for(int idx = 0; idx<orders.Count; idx++)
                {
                    Console.WriteLine("this item "+ orders[idx]);
                    orders.RemoveAt(idx);

                }
            }
        }
    }
   
   
   
   
}

