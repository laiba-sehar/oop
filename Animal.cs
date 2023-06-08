using System;
namespace week8task3.bl
{
    public class Animal
    {

        protected string name;
        public  Animal(string name)
        {
            this.name = name;
        }
        public virtual string greet()
        {
            return null;
        }
        public virtual string Tostring()
        {
            return "Name [ " + name + "]";
        }
    }
}
