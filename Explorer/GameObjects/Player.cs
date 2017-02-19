using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.GameObjects
{
    public class Player
    {
        public float LocX;
        public float LocY;
        public Point Location
        {
            get
            {
                return new Point((int)LocX, (int)LocY);
            }
        }
        public Point ChunkLocation
        {
            get
            {
                return new Point((int)Math.Floor(LocX / 16), (int)Math.Floor(LocY / 16));
            }
        }
    }
}
