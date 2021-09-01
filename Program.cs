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
            ClassicLinkedList<int> list = new ClassicLinkedList<int>();
            list.InsertAtIndex(0, 0);
            list.InsertAtIndex(1, 1);
            list.InsertAtIndex(2, 2);
            list.InsertAtIndex(3, 3);

            list.Print();
        } 
    }
}
