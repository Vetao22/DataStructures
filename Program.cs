using System;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicArray<int> arr = new ClassicArray<int>();

            arr.Add(15);
            arr.Add(7);
            arr.Add(30);
            arr.Add(2);
            arr.Add(100);

            arr.BubbleSort();

            arr.Print();
        }   
    }
}
