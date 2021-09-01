using System.Reflection.Metadata;
using System;
using System.Reflection.Metadata.Ecma335;
namespace DataStructures.Structures
{
    public class ClassicLinkedList<T> where T: IComparable
    {
        ClassicNode<T> firstNode, lastNode;
        
        public ClassicNode<T> FirstNode
        {
            get{ return firstNode;}
        }

        public ClassicNode<T> LastNode
        {
            get{ return lastNode; }
        }

        public ClassicLinkedList(ClassicNode<T> firstNode = null)
        {
            this.firstNode = firstNode;
            this.lastNode = null;
        }

        public T Read(short index)
        {
            ClassicNode<T> currentClassicNode = firstNode;
            short currentIndex = 0;

            while(currentIndex < index)
            {
                currentClassicNode = currentClassicNode.Next;
                currentIndex++;

                if(currentClassicNode == null)
                {
                    return default;
                }
            }

            return currentClassicNode.Data;
        }

        public short IndexOf(T value)
        {
            ClassicNode<T> currentClassicNode = firstNode;
            short currentIndex = 0;

            do
            {
                if(currentClassicNode.Data.CompareTo(value) == 0)
                {
                    return currentIndex;
                }

                currentClassicNode = currentClassicNode.Next;
                currentIndex++;
            }
            while(currentClassicNode != null);

            return default;
        }

        public void InsertAtIndex(short index, T value)
        {
            ClassicNode<T> newNode = new ClassicNode<T>(value);

            if(index == 0)
            {
                newNode.Next = firstNode;
                firstNode = newNode;
                lastNode = newNode;

                return;
            }

            ClassicNode<T> currentNode = firstNode;
            short currentIndex = 0;

            while(currentIndex < (index - 1))
            {
                currentNode = currentNode.Next;
                currentIndex++;
            }

            newNode.Previous = currentNode;
            currentNode.Next = newNode;
            lastNode = newNode;
        }

        public void InsertAtEnd(T value)
        {
            ClassicNode<T> newNode = new ClassicNode<T>(value);

            if(firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                newNode.Previous = lastNode;
                lastNode.Next = newNode;
                lastNode = newNode;
            }
        }
        
        public void DeleteAtIndex(short index)  
        {
            if(index == 0)
            {
                firstNode = firstNode.Next;
                FirstNode.Previous = null;

                return;
            }

            ClassicNode<T> currentNode = firstNode;
            short currentIndex = 0;

            while(currentIndex < (index - 1))
            {
                currentNode = currentNode.Next;
                currentIndex++;
            }

            currentNode.Next = currentNode.Next.Next;
            
            if(currentNode.Next != null)
            {
                lastNode = currentNode.Next;
                currentNode.Next.Previous = currentNode;
            }
            else
            {
                lastNode = currentNode;
            }
        }
    
        public void Reverse()
        {
            ClassicNode<T> previousNode = null, curNode = firstNode, nextNode;

            while(curNode != null)
            {
                nextNode = curNode.Next;
                curNode.Next = previousNode;
                previousNode = curNode;
                curNode = nextNode;
            }

            firstNode = previousNode;
        }
        public void Print()
        {
            ClassicNode<T> curNode = firstNode;
            short index = 0;

            while(curNode!= null)
            {
                Console.WriteLine($"Index: {index}, Value: {curNode.Data}");
                
                index++;
                curNode = curNode.Next;
            }
        }
    }
}