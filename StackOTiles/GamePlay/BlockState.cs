using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOTiles.GamePlay
{
    public enum BlockState
    {
        Idle,
        Falling,
        Moving,
        PostMove,
        Hover,
        Flash,
        Pop,
        Pop2,
        Pop3,
        Dead
    }
}
