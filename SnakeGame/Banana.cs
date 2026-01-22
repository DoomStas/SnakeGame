using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Banana : Fruit
    {
        public Banana(int x, int y) : base(x, y)
        {
        }
        public override int GrowBonus => 3;
        public override int SpeedBonus => 0;
    }
}
