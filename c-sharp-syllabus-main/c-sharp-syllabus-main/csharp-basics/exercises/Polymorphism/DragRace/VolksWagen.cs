using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class VolksWagen : IDragRace, IBoostable
    {
        private int _currentSpeed = 0;
        public void SpeedUp()
        {
            _currentSpeed += 13;
        }

        public void SlowDown()
        {
            _currentSpeed -= 13;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("EnnEnnEnnnnn....");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 20;
        }
    }
}
