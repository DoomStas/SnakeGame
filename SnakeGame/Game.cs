using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Game
    {
        public Snake Snake { get;}
        public List<Fruit> Fruits { get; }
        public bool IsGameOver { get; set; }

        public Game(int startX, int startY)
        { 
            Snake = new Snake(startX, startY);
            Fruits = new List<Fruit>();
            IsGameOver = false;
        }

        public void Update()
        {
            if (IsGameOver) return;
            Snake.Move();
            //Check for fruit collision
            
            Fruit eatenFruit = null;
            foreach (var fruit in Fruits)
            {
                if (fruit.Position == Snake.Head)
                {
                    eatenFruit = fruit;
                    break;
                }
            }
            if (eatenFruit != null)
            {
                int growValue = eatenFruit.GrowBonus;
                int speedValue = eatenFruit.SpeedBonus;
                for (int i = 0; i < growValue; i++)
                {
                    Snake.Eat();
                }
                if (speedValue > 0)
                {
                    Snake.SpeedUp(speedValue);
                }
                Fruits.Remove(eatenFruit);
            }
            if (Snake.IsSelfCollision())
            {
                IsGameOver = true;
            }
            
        }

        public void AddFruit(Fruit fruit)
        {
            Fruits.Add(fruit);
        }






    }
}
