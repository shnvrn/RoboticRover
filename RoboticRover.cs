using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticRovers
{
    public class RoboticRover
    {
        private int x { get; set; }
        private int y { get; set; }
        private string direction { get; set; }

        public void GoForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "E":
                    x += 1;
                    break;
            }

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
            }

        }
        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
            }

        }
        public string Move(string roverMove, string roverCurrentLocation)
        {
            char[] arrRoverMove = roverMove.ToCharArray();
            char[] arrRoverCurrentLocation = roverCurrentLocation.ToCharArray();

            string currentLocation = roverCurrentLocation;
            x = Convert.ToInt32(arrRoverCurrentLocation[0].ToString());
            y = Convert.ToInt32(arrRoverCurrentLocation[1].ToString());
            direction = arrRoverCurrentLocation[2].ToString();

            for (int i = 0; i < arrRoverMove.Length; i++)
            {
                switch (arrRoverMove[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        GoForward();
                        break;
                }
                Console.WriteLine((i + 1) + "." + "Move :" + x + " " + y + " " + direction + " " + "Command:" + arrRoverMove[i]);
            }

            return ("Last Position:" + x + " " + y + " " + direction);
        }

    }
}
