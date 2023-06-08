using System;
using coffeetask.BL;
using coffeetask.UI;

namespace coffeetask
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffeetask n = new Coffeetask();
            int option;
            double total = 0;
            while (true)
            {
                Console.Clear();
                option = UserInterface.mainMenu();
                if (option == 1)
                {
                    MenuItem m = coffeetask.UI.UserInterface.addMenuItem();
                    Coffeetask.storeInList(m);
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Coffeetask.viewCheapestItem();
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Coffeetask.viewDrinkMenu();
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Coffeetask.viewFoodMenu();
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    total = Coffeetask.addOrder();
                    Console.ReadKey();
                }
                else if (option == 6)
                {
                    Coffeetask.viewOrderInList();
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    Coffeetask.fulfillOrder();
                    Console.ReadKey();
                }
                else if (option == 8)
                {
                    UserInterface.dueAmount(total);
                    Console.ReadKey();
                }
                else if(option == 9)
                {
                    break;
                }
            }
        }
    }
}
