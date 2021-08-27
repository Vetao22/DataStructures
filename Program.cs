using System.Collections;
using System;
using System.Collections.Generic;

using DataStructures.Structures;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicQueue<int> stack = new ClassicQueue<int>();
            
            for(int x = 0;x < 10; x++)
            {
                stack.Enqueue(x);
            }

            stack.Dequeue();

            Console.WriteLine(stack.Read());
        }  
    }
}
