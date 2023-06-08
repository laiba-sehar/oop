using System;
namespace week8task2.bl
{
    public class student : person
    {
        private string program;
        private int year;
        private double fee;
        public student(string name, string address, string program, int year, double fee): base (name,address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
            public void setprogram(string program)
            {
                this.program=program;
            }
        public string getProgram()
        {
            return program;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear(int year)
        {
            return year;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public double getfee()
        {
            return fee;
        }
        public string Tostring()
        {
            return "Student[" + base.Tostring() + ", Program " + program + ",year " + year + ", Fee" + fee + "]";
        }

    }
}
