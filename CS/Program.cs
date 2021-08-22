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
                new int[] {1, 2, 3, 4}
                .Select(integer => integer * 2)
                .Min()
            );
            Console.ReadLine();
        }
    }
}