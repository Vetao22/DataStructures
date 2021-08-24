using System;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicArray<int> arr = new ClassicArray<int>();

            Random rnd = new Random();

            for(short x = 0; x < 100; x++)
            {
                arr.Add(rnd.Next(500));
            }

            arr.InsertionSort();

            arr.Print();
        }   
    }
}
