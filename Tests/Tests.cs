using System;
using Xunit;
using MarsRobot;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Robot robot = new Robot("1 2 N", "5 5");

            robot.ExecuteCommand("LMLMLMLMM");

            Assert.Equal("1 3 N", robot.x + " " + robot.y + " " + robot.direction);
        }

        [Fact]
        public void Test2()
        {
            Robot robot = new Robot("3 3 E", "5 5");

            robot.ExecuteCommand("MMRMMRMRRM");

            Assert.Equal("5 1 E", robot.x + " " + robot.y + " " + robot.direction);
        }
    }
}