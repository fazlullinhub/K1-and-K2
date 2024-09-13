using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int K1 = 5;
            int K2 = 10;

            int[] A = { 1, 3, 5, 7, 9, 12 };
            int[] B = { 2, 4, 6, 8, 11, 13 };

            var result = A.Where(x => x > K1)
                .Concat(B.Where(x => x < K2))
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine("The resulting sequence (sorted):");
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
