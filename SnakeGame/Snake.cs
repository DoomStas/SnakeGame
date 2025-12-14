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
        public (int X, int Y)[] Body { get; set; }

        //Direction of the snake
        public Direction CurentDirection { get; set; }

        //Length of the snake
        public int Length => Body.Length;

        //Head of the snake
        public (int X, int Y) Head => Body[0];

        //Constructor
        public Snake(int startX, int startY, int startLenght = 3)
        {
            Body = new (int X, int Y)[startLenght];
            for (int i = 0; i < startLenght; i++)
            {
                Body[i] = (startX - i, startY);
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

            //Create new body array with new head position
            (int X, int Y)[] newBody = new (int X, int Y)[Body.Length];
            //Set new head
            newBody[0] = newHead;
            //Shift the rest of the body
            for (int i = 1; i < Body.Length; i++)
            {
                newBody[i] = Body[i - 1];
            }
            Body = newBody;
        }
        
        //Eat food
        public void Eat()
        {
            (int X, int Y)[] newBody = new (int X, int Y)[Body.Length + 1];
            for (int i = 0; i < Body.Length; i++)
            {
                newBody[i] = Body[i];
            }
            // Duplicate the last segment to grow the snake
            newBody[newBody.Length - 1] = Body[Body.Length - 1];
            Body = newBody;
        }

        public bool IsSelfCollision()
        {
            for (int i = 1; i < Body.Length; i++)
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
