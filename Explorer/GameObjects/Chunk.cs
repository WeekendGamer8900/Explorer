using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.GameObjects
{
    public class Chunk
    {
        public Point Location;
        public Block[, ] region = new Block[15,15];
    }
}
