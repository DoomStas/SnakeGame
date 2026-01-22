using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class RegularFruit : Fruit
    {
       public RegularFruit(int x, int y) : base(x, y)
       {
       }
        public override int GrowBonus => 1;
        public override int SpeedBonus => 0;
    }
}
