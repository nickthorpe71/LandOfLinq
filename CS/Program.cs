using System;
using System.Collections;
using System.Linq;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                PositiveIntegers()
                .Skip(3)
                .Take(3)
                .Select(integer => integer * 2)
                .Min()
            );
            Console.ReadLine();
        }

        static IEnumerable<int> PositiveIntegers()
        {
            int currentIndex = 1;
            while(true)
            {
                yield return currentIndex++;
            }
        }
    }
}