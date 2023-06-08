using System;
namespace week8task4.bl
{
    public class shape
    {
        protected string type;
        public shape()
        {

        }
        public shape(string type)
        {
            this.type = type;
        }
        public virtual double getArea()
        {
            return 0;
        }
        public virtual string Tostring()
        {
            return " ";
        }
    }
    
}
