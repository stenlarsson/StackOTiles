using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StackOTiles.GamePlay;
using System.Diagnostics;

namespace StackOTiles.ArtificialIntelligence
{
    [DebuggerDisplay("{Type} {InChain}")]
    struct Location
    {
        public BlockType? Type;
        public bool InChain;
    }
}
