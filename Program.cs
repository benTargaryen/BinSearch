using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchkey;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
	    {
                numbers[i] = 1 + i;
	    }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Array {0}", numbers[i]);
            }
            searchkey = Convert.ToInt32(Console.ReadLine());
            int x = Array.BinarySearch(numbers, searchkey );

            Console.WriteLine("{0} Was found at {1}",numbers[x], x);

            Console.ReadLine();
        }
    }
}
