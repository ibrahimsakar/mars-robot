using System;

namespace MarsRobot
{
    public class Robot
    {
        public int x;
        public int y;
        public string direction;
        public int xMax;
        public int yMax;

        public Robot(string coordinate, string restriction)
        {
            // set x, y and direction.
            Int32.TryParse(coordinate.Split(" ")[0], out x);
            Int32.TryParse(coordinate.Split(" ")[1], out y);
            direction = coordinate.Split(" ")[2];

            // set restrictions
            Int32.TryParse(restriction.Split(" ")[0], out xMax);
            Int32.TryParse(restriction.Split(" ")[1], out yMax);
            
        }

        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "W":
                    direction = "S";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "E":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "W":
                    direction = "N";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "E":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void Go()
        {
            switch (direction)
            {
                case "N":
                    if (y + 1 <= yMax)
                        y += 1;
                    break;
                case "W":
                    if (x - 1 >= 0)
                        x -= 1;
                    break;
                case "S":
                    if (y - 1 >= 0)
                        y -= 1;
                    break;
                case "E":
                    if (x + 1 <= xMax)
                        x += 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void ExecuteCommand(string commands)
        {
            foreach(char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Go();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
