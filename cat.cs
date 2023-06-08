using System;
namespace week8task3.bl
{
    public class cat: Mammal
    {
        public cat(string name) : base(name)
        {
           
        }
        public override string greet()
        {
            return " Meoww";
        }
        public override string Tostring()
        {
            return "Cat " + base.Tostring() + " ]";
        }
    }
}
