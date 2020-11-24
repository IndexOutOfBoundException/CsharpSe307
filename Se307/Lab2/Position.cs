using System;

namespace ConsoleApp1.Lab2
{
    public class Position
    {
        private int x, y;

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public Position()
        {
           x=0;
           y=0;
        }

        public int MoveXBy(int val)
        {
            return x += val;
        }

        public int MoveYBy(int val)
        {
            return y += val;
        }

        public double CalculateDistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void ShowDistanceToOrigin()
        {
            Console.WriteLine("Distance: " +CalculateDistanceToOrigin());
        }

        public void DisplayLocation()
        {
            Console.WriteLine("("+x+","+y+")");
        }
    }
}