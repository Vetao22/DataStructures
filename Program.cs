using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicArray<int> arr = new ClassicArray<int>();
            Random rnd = new Random();

            for(short x = 0; x < 10; x++)
            {
                arr.Add(rnd.Next(40));
            }

            arr.QuickSort(0, (short)(arr.Length - 1));

            arr.Print();
        } 
    }
}
