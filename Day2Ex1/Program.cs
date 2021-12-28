using System;
using System.Collections.Generic;

namespace Day2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int position = 0;
            string command = Console.ReadLine();
            do
            {
                var directionParams = command.Split(' ');
                var direction = directionParams[0];
                var distance = int.Parse(directionParams[1]);

                if (direction == "forward")
                    position += distance;
                if (direction == "down")
                    depth += distance;
                if (direction == "up")
                    depth -= distance;

                command = Console.ReadLine();
            } while (!string.IsNullOrEmpty(command));
            Console.WriteLine(depth * position);
            Console.ReadLine();
        }
    }
}
