using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class VolksWagen : IDragRace, IBoostable
    {
        private int _currentSpeed = 0;
        public int SpeedUp()
        {
            _currentSpeed += 13;
            return _currentSpeed;
        }

        public int SlowDown()
        {
            _currentSpeed -= 13;
            return _currentSpeed;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "EnnEnnEnnnnn....";
        }

        public int UseNitrousOxideEngine()
        {
            _currentSpeed += 20;
            return _currentSpeed;
        }
    }
}
