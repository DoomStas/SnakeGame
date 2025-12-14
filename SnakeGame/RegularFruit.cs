using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class RegularFruit : Fruit
    {
        public string Name { get; }

        private static readonly string[] FruitNames = new string[]
        {
            "Cherry",
            "Orange",
            "Pineapple",
            "Strawberry",
            "Watermelon"
        };
        public RegularFruit(int x, int y) : base(x, y)
        {
            Random rand = new Random();
            Name = FruitNames[rand.Next(FruitNames.Length)];
        }
        public override void ApplyEffect(Snake snake)
        {
            snake.Eat(); //+1 length
        }
    }
}
