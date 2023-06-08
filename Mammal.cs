using System;
namespace week8task3.bl
{
    public class Mammal : Animal
    {
        public Mammal(string name): base(name)
        {
            
        }
        public override string Tostring()
        {
           return "Mammal" + base.Tostring() + "]";
        }
        
    }
}
