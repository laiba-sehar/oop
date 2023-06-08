using System;
using System.Collections.Generic;
using coffeetask.BL;

namespace coffeetask.UI
{
    public class UserInterface
    {
        public static int mainMenu()
        {
            int option;
            Console.WriteLine("-->  WELCOME TO COFFEE SHOP  <--");
            Console.WriteLine("1.ADD A MENU ITEM");
            Console.WriteLine("2.VIEW THE CHEAPEST ITEM IN THE MENU");
            Console.WriteLine("3.VIEW THE DRINK'S MENU");
            Console.WriteLine("4.VIEW THE FOOD'S MENU");
            Console.WriteLine("5.ADD ORDER");
            Console.WriteLine("6.FULFILL THE ORDER");
            Console.WriteLine("7.VIEW THE PRODUCT'S LIST");
            Console.WriteLine("8.TOTAL PAYABLE AMOUNT");
            Console.WriteLine("9.EXIT");
            Console.WriteLine("Choose your option:");
            option = int.Parse(Console.ReadLine());
            return option;

        }


        public static MenuItem addMenuItem()
        {
            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter type FOOD or DRINK:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = int.Parse(Console.ReadLine());
            MenuItem m = new MenuItem(name, type, price);
            return m;

        }
        public static void dueAmount(double total)
        {
            Console.WriteLine("Total amount {0}", total);
        }
    }
}
