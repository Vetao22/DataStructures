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
            ClassicHashTable hashTable = new ClassicHashTable();

            hashTable.Add("teste","01");
            hashTable.Add("teste", "02");
            hashTable.Add("everton", "123456");

            hashTable.Print();
        }  
    }
}
