using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class CarFleet
    {
        public int CarFleetCount(int target, int[] position, int[] speed)
        {
            Array.Sort(position, speed);
            double previousValue = 0.0;
            int fleetCount = 0;

            for (int counter = speed.Length - 1; counter >= 0; counter--)
            {
                var timeTaken = -1.0;
                if (speed[counter] != 0)
                {
                    timeTaken = (target - position[counter]) / (double)speed[counter];
                }

                if (timeTaken > previousValue)
                {
                    previousValue = timeTaken;
                    fleetCount++;
                }
            }

            return fleetCount;
        }
    }
}
