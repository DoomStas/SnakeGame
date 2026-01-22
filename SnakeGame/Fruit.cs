using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public abstract class Fruit
    {
        public (int X, int Y) Position { get; set; }
        protected Fruit(int x, int y)
        {
            Position = (x, y);
        }
        public abstract int GrowBonus { get; }
        public abstract int SpeedBonus {get;}
    }
}
