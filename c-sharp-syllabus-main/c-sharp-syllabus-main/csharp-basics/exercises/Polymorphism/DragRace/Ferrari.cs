using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Ferrari : IDragRace
    {
        private int _currentSpeed = 0;
        public int SpeedUp()
        {
            _currentSpeed += 25;
            return _currentSpeed;
        }

        public int SlowDown()
        {
            _currentSpeed -= 25;
            return _currentSpeed;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "ZummZum.Zummmmm";
        }
    }
}
