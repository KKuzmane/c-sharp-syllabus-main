using System;

namespace DragRace
{
    public class Lexus : IDragRace, IBoostable
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

        public int UseNitrousOxideEngine() 
        {
            currentSpeed +=30;
            return currentSpeed;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}