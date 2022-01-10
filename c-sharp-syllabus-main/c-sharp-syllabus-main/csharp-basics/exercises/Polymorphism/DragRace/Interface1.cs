using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface IDragRace
    {
        int SpeedUp();
        int SlowDown();
        string ShowCurrentSpeed();
        string StartEngine();
    }
}
