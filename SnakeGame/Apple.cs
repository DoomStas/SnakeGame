using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Apple : Fruit
    {
        public Apple(int x, int y) : base(x, y)
        { 
        }
        public override int GrowBonus => 0;
        public override int SpeedBonus => 5;
    }


}
