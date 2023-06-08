using System;
using System.Collections.Generic;
using week8task4.bl;
using week8task4.UI;
namespace week8task4.Dl
{
    public class dlclass
    {
        public static List<shape> shapes = new List<shape>();
        public static void AddInList(rectangle rec,circle cir,square sqr)
        {
            shapes.Add(rec);
            shapes.Add(cir);
            shapes.Add(sqr);
        }
       
    }
    
}
