using System;

namespace DragRace
{
    public class Tesla : IDragRace
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            currentSpeed += 15;
            return currentSpeed;
        }

        public int SlowDown() 
        {
            currentSpeed -= 15;
            return currentSpeed;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public string StartEngine() 
        {
            return "-- silence ---";
        }
    }
}