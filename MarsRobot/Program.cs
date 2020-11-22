using System;

namespace MarsRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("1 2 N", "5 5");

            robot.ExecuteCommand("LMLMLMLMM");
            
            Console.WriteLine("The robot on {0}, {1}, {2}", robot.x, robot.y, robot.direction);
            
            Robot robot2 = new Robot("3 3 E", "5 5");

            robot2.ExecuteCommand("MMRMMRMRRM");
            
            Console.WriteLine("The robot on {0}, {1}, {2}", robot2.x, robot2.y, robot2.direction);
        }
    }
}
