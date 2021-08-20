using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Structures.ClassicArray<int> arr = new Structures.ClassicArray<int>();

            arr.Add(0);
            arr.Add(1);
            
            arr.Insert(5, 2);

            arr.Print();
        }
    }
}
