using System;
namespace week8task4.bl
{
   
    public class square:shape
    {
        private double s;
        public square(double s,string type) : base(type)
        {
            this.s = s;
        }
        public void setS(double s)
        {
            this.s = s;
        }
        public double getS()
        {
            return s;
        }
        public override double getArea()
        {
            double result = s * s;
            return result;
        }
        public override string ToString()
        {
            return "The shape is " + type + " and its area is " + getArea();
        }

    }

}
