using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.GameObjects
{
    public class World
    {
        public List<Chunk> Chunks = new List<Chunk>();
        public Player player;

        public Chunk GetPlayerChunk()
        {
            Point p = player.GetChunkLocation();
            for (int i = Chunks.Count-1; i >=0; i++)
            { 
                if (Chunks[i].Location == p)
                {
                    return Chunks[i];
                }
            }
            return null; //should generate a new chunk if code runs to here
        }
    }
}
