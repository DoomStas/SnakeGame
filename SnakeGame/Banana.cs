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
        public override void ApplyEffect(Snake snake)
        {
            snake.Eat(); 
            snake.Eat();     
            snake.Eat();
        }
    }
}
