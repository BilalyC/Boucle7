using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int counter;
            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(numbers[counter]);
            }
            /*
            foreach (int number in numbers.Take(10)) // Récupere les dix premiers nombres grace à la fonction Take()
            {
                Console.WriteLine(numbers[counter]);
            }*/
        }
    }
}
