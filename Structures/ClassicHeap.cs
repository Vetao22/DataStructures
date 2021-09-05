using System;
namespace DataStructures.Structures
{
    public class ClassicHeap<T> where T: IComparable<T>
    {
        ClassicArray<T> data;

        public T First
        {
            get{ return data.First; }
        }

        public T Last
        {
            get{ return data.Last; }
        }

        public ClassicHeap()
        {
            data = new ClassicArray<T>();
        }

        short LeftChildIndex(short index)
        {
            return (short)((index * 2) + 1);
        }

        short RightChildIndex(short index)
        {
            return (short)((index * 2) + 2);
        }

        short ParentIndex(short index)
        {
            return (short)((index - 2) / 2);
        }

        public void Insert(T value)
        {
            data.Add(value);

            short newNodeIndex = (short)(data.Length - 1);

            while(newNodeIndex > 0 && 
                data.GetValue(newNodeIndex).CompareTo(data.GetValue(ParentIndex(newNodeIndex))) > 0)
            {
                data.SwapIndexes(ParentIndex(newNodeIndex), newNodeIndex);
                //data.SwapIndexes(newNodeIndex, ParentIndex(newNodeIndex));
                
                newNodeIndex = ParentIndex(newNodeIndex);
            }
        }
    
        public void Delete()
        {
            data.SetValue(0, data.RemoveAtIndex((short)(data.Length - 1)));

            short trickleNodeIndex = 0;

            while(HasGreaterChild(trickleNodeIndex))
            {
                short largerChildIndex = CalculateLargerChildIndex(trickleNodeIndex);

                data.SwapIndexes(trickleNodeIndex, largerChildIndex);

                trickleNodeIndex = largerChildIndex;
            }
        }

        bool HasGreaterChild(short index)
        {
            if(LeftChildIndex(index) < 0  || RightChildIndex(index) < 0)
            {
                return false;
            }

            if(data.GetValue(LeftChildIndex(index)).CompareTo(data.GetValue(index)) > 0 ||
                data.GetValue(RightChildIndex(index)).CompareTo(data.GetValue(index)) > 0)
            {
                return true;
            }

            return false;
        }
    
        short CalculateLargerChildIndex(short index)
        {
            if(data.GetValue(RightChildIndex(index)) == null)
            {
                return LeftChildIndex(index);
            }

            if(data.GetValue(RightChildIndex(index)).CompareTo(data.GetValue(LeftChildIndex(index))) > 0)
            {
                return RightChildIndex(index);
            }
            else
            {
                return LeftChildIndex(index);
            }
        }
    
        public void Print()
        {
            data.Print();
        }
    }
}