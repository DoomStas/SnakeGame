using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        //Body of the snake
        public List<(int X, int Y)> Body { get; set; }

        //Direction of the snake
        public Direction CurentDirection { get; set; }

        //Length of the snake
        public int Length => Body.Count;

        //Head of the snake
        public (int X, int Y) Head => Body[0];

        //Constructor
        public Snake(int startX, int startY, int startLenght = 3)
        {
            Body = new List<(int X, int Y)>();
            for (int i = 0; i < startLenght; i++)
            {
                Body.Add ((startX - i, startY));
            }
            CurentDirection = Direction.Right;
        }

        //Move the snake in the current direction
        public void Move()
        { 
            (int X, int Y) newHead = Head;
            switch (CurentDirection)
            {
                case Direction.Up:
                    newHead.Y --;
                    break;
                case Direction.Down:
                    newHead.Y ++;
                    break;
                case Direction.Left:
                    newHead.X --;
                    break;
                case Direction.Right:
                    newHead.X ++;
                    break;
            }

            Body.Insert(0, newHead);
            Body.RemoveAt(Body.Count - 1);
        }

        public void Eat()
        {
            Body.Add(Body.Last());
        }
     

        public bool IsSelfCollision()
        {
            for (int i = 1; i < Body.Count; i++)
            {
                if (Body[i].X == Head.X && Body[i].Y == Head.Y)
                {
                    return true;
                }
            }
            return false;
        }

        //Speed up the snake
        public int SpeedBoostTurns { get; set; }
        public void SpeedUp(int turns)
        {
            SpeedBoostTurns += turns;
        }
        public void DecreaseSpeedBoost()
        {
            if (SpeedBoostTurns > 0)
            {
                SpeedBoostTurns--;
            }
        }
    }
}
