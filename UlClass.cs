using System;
using System.Collections.Generic;
using week8task4.bl;
using week8task4.Dl;
namespace week8task4.UI

{
    public class UlClass
    {
        private IEnumerable<shape> shapes;

        public static rectangle takeInput1()
        {
            Console.WriteLine("Enter the value of height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of width");
            double width = double.Parse(Console.ReadLine());
            rectangle rec = new rectangle(height, width,"rectangle");
            return rec;
        }
        public static square takeInput2()
        {
            Console.WriteLine("Enter the value of side");
            double side = double.Parse(Console.ReadLine());
            square sqr = new square(side,"square");
            return sqr;
            
        }
        public static circle takeInput3()
        {
            Console.WriteLine("Enter the value of radius");
            double radius = double.Parse(Console.ReadLine());
            circle cir = new circle(radius,"circle");
            return cir;

        }
        public static void display()
        {
            foreach (shape s in dlclass.shapes)
            {
                Console.WriteLine(s.Tostring());
            }
        }
    }
}
