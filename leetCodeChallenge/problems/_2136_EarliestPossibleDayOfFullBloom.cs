using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _2136_EarliestPossibleDayOfFullBloom
    {
        public int EarliestFullBloom(int[] plantTime, int[] growTime)
        {
            List<Plant> plants = new List<Plant>();
            for (int i = 0; i < plantTime.Length; i++)
            { 
                plants.Add(new Plant(plantTime[i], growTime[i]));
            }

            plants.Sort();

            int frontTime = 0;
            foreach(Plant plant in plants)
            {
                int currentGrow = Math.Max(frontTime, plant.growTime);
                frontTime = currentGrow + plant.plantTime;
            }

            return frontTime;
        }

       
    }

    public class Plant: IComparable<Plant>
    {
        public int plantTime;
        public int growTime;

        public Plant(int plantTime, int growTime)
        {
            this.plantTime = plantTime;
            this.growTime = growTime;
        }

        public int CompareTo(Plant other)
        {
            return this.growTime.CompareTo(other.growTime);
        }
    }
}
