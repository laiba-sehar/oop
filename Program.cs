
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task6
{
    class Program
    {
        class product
        {
            public string name;
            public string catagory;
            public int price;
            public int stock;
            public int minimumStock;
        }
        static void Main(string[] args)
        {
            product s = new product();
            List<product> p = new List<product>();
         

        }
        static product addProduct(product s)
        {
            Console.WriteLine("Enter name of the product :");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter catagory of the product :");
            s.catagory = Console.ReadLine();
            Console.WriteLine("Enter price of the product :");
            s.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock Quantity of the product :");
            s.stock=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimum stock Quantity of the product :");
            s.minimumStock = int.Parse(Console.ReadLine());
            Console.WriteLine("Added successfully");
            Console.WriteLine("Press any key to continue...");
            return s;
        }
        static void viewProduct(List<product> p)
        {
            for(int i=0;i<p.Count;i++)
            {
                Console.Write("Name of product :");
                Console.WriteLine(p[i].name);
                Console.Write("catagory of product :");
                Console.WriteLine(p[i].catagory);
                Console.Write("price of product :");
                Console.WriteLine(p[i].price);
                Console.Write("stock Quantity of product :");
                Console.WriteLine(p[i].stock);
                Console.Write("minimum stock Quantity of product :");
                Console.WriteLine(p[i].minimumStock);
            }

        }
    }
}
