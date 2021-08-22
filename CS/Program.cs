using System;
using System.Collections;
using System.Linq;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] {1, 2, 3, 4};
            var filteredList = list.Where(integer => integer % 2 == 0);
            Console.WriteLine(filteredList.Select(integer => integer * 2).Sum());
            Console.ReadLine();
        }
    }
}