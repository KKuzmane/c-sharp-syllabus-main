using System;

namespace DragRace
{
    public class Bmw : IDragRace
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            currentSpeed += 10;
            return currentSpeed;
        }

        public int SlowDown() 
        {
            currentSpeed -= 10;
            return currentSpeed;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}