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
            ClassicTreeNode<int> root = new ClassicTreeNode<int>(50);

            ClassicBinarySearchTree<int> tree = new ClassicBinarySearchTree<int>(root);
            tree.Insert(30, tree.Root);
            tree.Insert(70, tree.Root);
            tree.Insert(25, tree.Root);
        } 
    }
}
