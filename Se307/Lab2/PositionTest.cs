using System;

namespace ConsoleApp1.Lab2
{
    public class PositionTest
    {
        public static void Main(string[] args)
        {
            Position position = new Position();
            
            Console.WriteLine("Constructor Values:");
            position.DisplayLocation();
            position.ShowDistanceToOrigin();
            position.MoveXBy(2);
            position.MoveYBy(7);
            Console.WriteLine("After X and Y moved: ");
            position.DisplayLocation();
            position.ShowDistanceToOrigin();
            
            
            Console.WriteLine("====================");
            
            position.X = 3;
            position.Y = 4;
            
            position.DisplayLocation();
            position.ShowDistanceToOrigin();
            position.MoveXBy(6);
            position.MoveYBy(8);
            Console.WriteLine("After X and Y moved: ");
            position.DisplayLocation();
            position.ShowDistanceToOrigin();
            
            
            
            
            
        }
    }
}