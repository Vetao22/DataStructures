using System;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicSet<int> set = new ClassicSet<int>();

            for(short x = 0; x < 200; x++)
            {
                set.Add(x);
            }

            Console.WriteLine($"Index: {set.GetIndex(199)}");
        }   
    }
}
