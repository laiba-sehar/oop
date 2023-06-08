using System;
namespace week8task2.bl
{
    public class staff : person
    {
        private string school;
        private double pay;
        public staff(string name, string address, string school, double pay): base(name,address)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;

        }
        public void setschoool(string school)
        {
            this.school = school;
        }
        public string getschoool()
        {
            return school;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }
        public double getpay()
        {
            return pay;
        }
        public string Tostring()
        {
            return "Student[" + base.Tostring() + ", school " + school + ", " + pay  + "]";
        }

    }
    }
