using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.GameObjects
{
    public class Block
    {
        public BlockType Type;
        public int X;
        public int Y;
        public int Z;
    }

    public enum BlockType
    {
        Grass,
        Stone,

    }
}
