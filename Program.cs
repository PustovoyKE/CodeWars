using System;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ans = {36, 37, 38, 31, 24, 25, 26};
            var maze = new[]
            {
                false, false, false, false, false, false, false,
                false, true, false, true, true, true, false,
                false, true, false, true, false, false, false,
                false, true, true, true, true, true, false,
                false, false, false, true, false, true, false,
                false, true, true, true, false, true, false,
                false, false, false, false, false, false, false,
            };

            var result = FindPath(maze, 7, 36, 26);

            Console.ReadKey();
        }

        public static int[] FindPath(bool[] maze, int size, int startIndex, int goalIndex)
        {
            var result = new Stack<int>();
            var currentIndex = startIndex;

            //Поиск клеток, куда можно пойти
            var freeSpace = new Stack<int>();
            if (maze[currentIndex + 1]) freeSpace.Push(currentIndex + 1);
            if (maze[currentIndex - 1]) freeSpace.Push(currentIndex - 1);
            if (maze[currentIndex + size]) freeSpace.Push(currentIndex + size);
            if (maze[currentIndex - size]) freeSpace.Push(currentIndex - size);

            foreach (var i in freeSpace)
            {
                
            }

            result.Push();


            return freeSpace.ToArray();
        }
    }
}