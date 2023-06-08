using System;
namespace week8task3.bl
{
    public class Dog:Mammal

    {
        public Dog(string name) : base(name)
        {

        }
        public override string greet()
        {
            return "wooof ";
        }
        public override string Tostring()
        {
            return "Dog " + base.Tostring() + " ]";
        }
    }
}
