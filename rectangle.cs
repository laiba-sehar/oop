using System;
namespace week8task4.bl
{
    public class rectangle : shape
    {
        private double height;
        private double width;
        
        public rectangle(double height, double width,string type):base(type)

        {
            this.height = height;
            this.width = width;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidtht()
        {
            return width;
        }
        public override double getArea()
        {
            return height * width;
        }
        public override string ToString()
        {
            return "The shape is " + type + " and its area is" + getArea();
        }
    }
}
