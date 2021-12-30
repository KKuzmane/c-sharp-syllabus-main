using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface IDragRace
    {
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
