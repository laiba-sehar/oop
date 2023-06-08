using System;
namespace week8task2.bl
{
    public class person
    {
        protected string name;
        protected string address;
        public person(string name,string address)
        {
            this.name = name;
            this.address= address;
        }
        public void setName(string name)
        {
            this.name =name;
            
        }

        public string getName()
        {
            return name;

        }
        public void setaddress(string address)
        {
            this.address = address;

        }

        public string getAddress()
        {
            return address;

        }
        public string Tostring()
        {
            return "Person [ name =" + name + ", address =" + address + "]";
        }
    }
}
