using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Question3
    {

        public void FindNthSmallestNum(int n)
        {
            // generating random numbers and storing in an array
            int[] randomNumbers = new int[500];

            for (int x = 0; x < 500; x++)
            {
                randomNumbers[x] = (new Random()).Next();
            }

            // soritng the array
            for (int i = 1; i <= 500; i++)
            {
                for (int j = 1; j <= 499; j++)
                {
                    if (randomNumbers[j] > randomNumbers[j + 1])
                    {
                        int temp = randomNumbers[j];
                        randomNumbers[j] = randomNumbers[j + 1];
                        randomNumbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(n + "th smallest number is: " + randomNumbers[n - 1]);


        }
    }
}
