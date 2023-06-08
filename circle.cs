using System;
namespace week8task4.bl
{
    public class circle:shape
    {
        private double radius;
        public circle(double radius,string type):base(type)
        {
            this.radius = radius;
        }
       public void setCircle(double radius)
        {
            this.radius = radius;
        }
        public double getCircle()
        {
            return radius;
        }
        public override double getArea()
        {
            return 3.14*radius*radius;
        }
        public override string ToString()
        {
            return "The shape is " + type + " and its area is " + getArea();
        }
    }
}
