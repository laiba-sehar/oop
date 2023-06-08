using System;
using System.Collections.Generic;
namespace ship
{
    public class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;
        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
    }
   
}
