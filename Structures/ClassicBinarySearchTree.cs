using System;

namespace DataStructures.Structures
{
    public class ClassicBinarySearchTree<T> where T: IComparable
    {
        public ClassicTreeNode<T> Root { get; set; }

        public ClassicBinarySearchTree(ClassicTreeNode<T> root)
        {
            Root = root;
        }

        public ClassicTreeNode<T> Search(T searchValue, ClassicTreeNode<T> node)
        {
            if(node == null || node.Data.CompareTo(searchValue) == 0)
            {
                return node;
            }

            if(searchValue.CompareTo(node.Data) > 0)
            {
                return Search(searchValue, node.RightChild);
            }
            else
            {
                return Search(searchValue, node.LeftChild);
            }
        }
    
        public void Insert(T data, ClassicTreeNode<T> node)
        {
            if(data.CompareTo(node.Data) < 0)
            {
                if(node.LeftChild == null)
                {
                    node.LeftChild = new ClassicTreeNode<T>(data);
                }
                else
                {
                    Insert(data, node.LeftChild);
                }
            }
            else if(data.CompareTo(node.Data) > 0)
            {
                if(node.RightChild == null)
                {
                    node.RightChild = new ClassicTreeNode<T>(data);
                }
                else
                {
                    Insert(data, node.RightChild);
                }
            }
        }
   
        ClassicTreeNode<T> Lift(ClassicTreeNode<T> node, ClassicTreeNode<T> nodeToDelete)
        {
            if(node.LeftChild != null)
            {
                node.LeftChild = Lift(node.LeftChild, nodeToDelete);
                return node;
            }
            else
            {
                nodeToDelete.Data = node.Data;
                return node.RightChild;
            }
        }
    
        public ClassicTreeNode<T> Delete(T valueToDelete, ClassicTreeNode<T> node)
        {
            if(node == null)
            {
                return null;
            }

            if(valueToDelete.CompareTo(node.Data) < 0)
            {
                node.LeftChild = Delete(valueToDelete, node.LeftChild);
                return node;
            }
            else if(valueToDelete.CompareTo(node.Data) > 0)
            {
                node.RightChild = Delete(valueToDelete, node.RightChild);
                return node;
            }
            else
            {
                if(node.LeftChild == null)
                {
                    return node.RightChild;
                }
                else if(node.RightChild == null)
                {
                    return node.LeftChild;
                }
                else
                {
                    node.RightChild = Lift(node.RightChild, node);
                    return node;    
                }
            }
        }
    
        public void Print(ClassicTreeNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            Print(node.LeftChild);

            Console.WriteLine($"Value: {node.Data}");

            Print(node.RightChild);
        }
    }
}