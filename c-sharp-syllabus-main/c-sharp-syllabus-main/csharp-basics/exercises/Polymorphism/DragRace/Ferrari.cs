using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Ferrari : IDragRace
    {
        private int _currentSpeed = 0;
        public void SpeedUp()
        {
            _currentSpeed += 25;
        }

        public void SlowDown()
        {
            _currentSpeed -= 25;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("ZummZum.Zummmmm");
        }
    }
}
