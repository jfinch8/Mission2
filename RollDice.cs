using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        //generate random numbers
        private readonly Random random;

        public RollDice()
        {
            //initialize the random field from above
            random = new Random();
        }

        public int[] SimulateDiceRolls(int numberOfRolls)
        {
            //array to store the counts of each outcome
            int[] results = new int[13];

            //loop through dice rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                //random number for first die
                int dice1 = random.Next(1, 7);
                //random number for second die
                int dice2 = random.Next(1, 7);
                //calculate sum of the two dice
                int sum = dice1 + dice2;
                //increment the count for that sum in the results array
                results[sum]++;
            }
            //return array with results
            return results;
        }
    }
}
