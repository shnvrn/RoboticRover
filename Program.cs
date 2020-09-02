using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticRovers
{
    public class Program
    {
        static void Main(string[] args)
        {
            RoboticRover roverManager = new RoboticRover();
            string location = string.Empty;

            List<string> roverCurrentLocation = new List<string>();
            roverCurrentLocation.Add("1,2,N");
            roverCurrentLocation.Add("3,3,E");

            List<string> roverMovesList = new List<string>();
            roverMovesList.Add("LMLMLMLMM");
            roverMovesList.Add("MMRMMRMRRM");

            for (int i = 0; i < roverMovesList.Count; i++)
            {
                Console.WriteLine(string.Format("{0},{1},{2}","Rover started to move", "Commands" + "=" + roverMovesList[i], "Current Location" + "=" + roverCurrentLocation[i]));
                location = roverManager.Move(roverMovesList[i], roverCurrentLocation[i].Replace(",", "").Trim());
                Console.WriteLine(location);

                if (i != roverMovesList.Count - 1)
                    Console.WriteLine("----------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
