using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        //Body and head of the snake
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
                Body.Add((startX - i, startY));
            }
            CurentDirection = Direction.Right;
        }

        //Move the snake in the current direction
        public void Move()
        { 
            var head = Head;
            switch (CurentDirection)
            {
                case Direction.Up:
                    head.Y -= 1;
                    break;
                case Direction.Down:
                    head.Y += 1;
                    break;
                case Direction.Left:
                    head.X -= 1;
                    break;
                case Direction.Right:
                    head.X += 1;
                    break;
            }
            Body.Insert(0, head);
            Body.RemoveAt(Body.Count - 1);
        }
        //Eat food
        public void Eat()
        {
            var tail = Body[Body.Count - 1];
            Body.Add(tail);
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


    }
}
