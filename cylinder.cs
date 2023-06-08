using System;
namespace week8task1.Bl
{
    public class cylinder:circle
    {
        private double height;
        public cylinder() : base()
        {
            height = 1.0;
        }
        public cylinder(double radius)
        {
            this.radius = radius;
        }
        public cylinder(double radius, double height): base(radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public cylinder(double radius, double height, string color): base(radius,color)
        {
            this.radius = radius;
            this.height = height;
            this.color = color;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public double getVolume()
        {
            double Volume;
            Volume = 3.14 * radius * radius * height;
            return Volume;
        }
    }
}
