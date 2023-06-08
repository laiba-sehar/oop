using System;
namespace coffeetask.BL
{
    public class MenuItem
    {
        public string name;
        public string type;
        public int price;
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;

        }
        public MenuItem(string itemName)
        {
            this.name = itemName;
        }
    }
}
