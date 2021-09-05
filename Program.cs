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
            ClassicHeap<int> heap = new ClassicHeap<int>();

            heap.Insert(1);
            heap.Insert(4);
            heap.Insert(2);
            heap.Insert(6);

            heap.Delete();
            heap.Delete();

            heap.Print();
        } 
      
    }
}
