using System;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicSet<int> set = new ClassicSet<int>();

            set.Add(0);
            set.Add(5);
            set.Add(0);
            set.Add(3);

            set.Print();
        }   
    }
}
