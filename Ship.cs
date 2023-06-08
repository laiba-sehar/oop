using System;
using System.Collections.Generic;
namespace ship
{
    public class Ship
    {
        public string shipNo;
        public Angle longitude;
        public Angle latitude;
        

        public Ship(string shipNo,Angle latitude, Angle longitude)
        {
            this.shipNo = shipNo;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public Ship()
        {

        }
    }
}
