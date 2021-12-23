using System;
using System.Collections.Generic;

namespace Day1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var increases = 0;
            List<int> depths = new List<int>();
            int depth = int.Parse(Console.ReadLine());
            do
            {
                depths.Add(depth);
                depth = int.Parse(Console.ReadLine());
            } while (depth != 0);
            for (int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > depths[i - 1])
                    increases += 1;
            }
            Console.WriteLine(increases);
            Console.ReadLine();
        }
    }
}
