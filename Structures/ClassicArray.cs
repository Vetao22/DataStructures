using System;

namespace DataStructures.Structures
{
    public class ClassicArray<T> where T: IComparable<T>
    {
        T[] arr = new T[0];
       
        public T First
        {
            get{ return arr[0]; }
        }

        public T Last
        {
            get{ return arr[Length - 1]; }
        }
        
        public short Length
        {
            get{ return (short)arr.Length; }
        }
        
        public void Add(T value)
        {
            if(value != null)
            {                
                Insert((short)arr.Length, value);
            }
        }

        public void Insert(short index, T value)
        {
            T[] temp = new T[arr.Length + 1];

            if(index > temp.Length)
            {
                index = (short)(temp.Length - 1);
            }

            if(index >= 0 && index < temp.Length && value != null)
            {
                for(short x = 0; x < index; x++)
                {
                    temp[x] = arr[x];
                }
                temp[index] = value;

                index++;

                for(short x = index; x < temp.Length; x++)
                {
                    temp[x] = arr[x - 1];
                }

                arr = temp;
            }
        }
        
        public void SetValue(short index, T value)
        {
            if(index < 0 || index > Length - 1)
            {
                return;
            }

            arr[index] = value;
        }
        public void SwapIndexes(short index, short index2)
        {
            if(index < 0 || index > Length - 1)
            {
                return;
            }

            if(index2 < 0 || index2 > Length - 1)
            {
                return;
            }

            T temp = arr[index];
            arr[index] = arr[index2];
            arr[index2] = temp;
        }

        public T GetValue(short index)
        {
            T value = default(T);

            if(index < arr.Length)
            {
                value = arr[index];
            }

            return value;
        }

        public short GetIndex(T value)
        {
            return BinarySearch(value);
        }

        public T Remove(T valueToRemove)
        {
            short index = LinearSearch(valueToRemove);
            T deleted = default;

            if(index != -1)
            {
                T[] temp = new T[arr.Length -1];
                short addIndex = 0;

                for(short x = 0; x < arr.Length; x++)
                {
                    if(x != index)
                    {
                        temp[addIndex] = arr[x];
                        addIndex++;
                    }
                    else
                    {
                        deleted = arr[x];
                    }
                }

                arr = temp;
            }

            return deleted;
        }

        public T RemoveAtIndex(short index)
        {
            if(index < 0 || index > Length - 1)
            {
                return default;
            }

            T deleted = default;
            T[] tempArr = new T[Length - 1];
            short newIndex = 0;

            for(short x = 0; x < Length; x++)
            {
                if(x != index)
                {
                    tempArr[newIndex] = arr[x];
                    newIndex++;
                }
                else
                {
                    deleted = arr[x];
                }
            }

            arr = tempArr;

            return deleted;
        }
        
        short LinearSearch(T value)
        {
            for(short x = 0; x < arr.Length; x++)
            {
                if(arr[x].Equals(value))
                {
                    return x;
                }
            }
            return -1;
        }
    
        short BinarySearch(T value)
        {
            short index = -1, checkIndex, lowerBound = 0, upperBound = (short)(arr.Length - 1);

            while(lowerBound <= upperBound)
            {
                checkIndex = (short)Math.Abs((upperBound + lowerBound) / 2);
                
                if(arr[checkIndex].Equals(value))
                {
                    index = checkIndex;
                    return index;
                }
                if(value.CompareTo(arr[checkIndex]) > 0)
                {
                    lowerBound = (short)(checkIndex + 1);
                }
                else
                {
                    upperBound = (short)(checkIndex - 1);
                }
            }
            return index;
        }

        public void BubbleSort()
        {
            short unsortedIndex = (short)(arr.Length - 1);
            bool sorted = false;

            while(!sorted)
            {
                sorted = true;

                for(short x = 0; x < unsortedIndex; x++)
                {
                    if(arr[x].CompareTo(arr[x + 1]) > 0)
                    {
                        T temp = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = temp;

                        sorted = false;

                        unsortedIndex--;
                    }
                }
            }
        }
        
        public void SelectionSort()
        {
            for(short x = 0; x < arr.Length - 1; x++)
            {
                short lowestNumberIndex = x;

                for(short y = (short)(x + 1); y < arr.Length; y++)
                {
                    if(arr[y].CompareTo(arr[lowestNumberIndex]) < 0)
                    {
                        lowestNumberIndex = y;
                    }
                }

                if(lowestNumberIndex != x)
                {
                    T temp = arr[x];
                    arr[x] = arr[lowestNumberIndex];
                    arr[lowestNumberIndex] = temp;
                }
            }
        }

        public void InsertionSort()
        {
            for(short index = 1; index < arr.Length; index++)
            {
                T temp = arr[index];
                short checkIndex = (short)(index - 1);

                while(checkIndex >= 0)
                {
                    if(arr[checkIndex].CompareTo(temp) > 0)
                    {
                        arr[checkIndex + 1] = arr[checkIndex];
                        checkIndex--;
                    }
                    else
                    {
                        break;
                    }
                    arr[checkIndex + 1] = temp;
                }
            }
        }
       
        short Partition(short leftPointer, short rightPointer)
        {
            short pivotIndex = rightPointer;
            T pivot = arr[pivotIndex];
            rightPointer--;

            while(true)
            {            
                while(arr[leftPointer].CompareTo(pivot) < 0)
                {
                    leftPointer++;
                }

                while(arr[rightPointer].CompareTo(pivot) > 0)
                {
                    rightPointer--;
                }               

                if(leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {
                    T temp = arr[rightPointer];
                    arr[rightPointer] = arr[leftPointer];
                    arr[leftPointer] = temp;

                    leftPointer++;
                }                
            }

            arr[pivotIndex] = arr[leftPointer];
            arr[leftPointer] = pivot;        

            return leftPointer;
        }
        
        public void QuickSort(short leftIndex, short rightIndex)
        {
            short pivotIndex;

            if(rightIndex - leftIndex <= 0)
            {
                return;
            }

            pivotIndex = Partition(leftIndex, rightIndex);

            QuickSort(leftIndex, (short)(pivotIndex - 1));

            QuickSort((short)(pivotIndex + 1), rightIndex);
        }
        

        public T QuickSelect(short kthLowestValue, short leftIndex, short rightIndex)
        {
            if(rightIndex - leftIndex < 0)
            {
                return arr[leftIndex];
            }

            short pivotIndex = Partition(leftIndex, rightIndex);

            if(kthLowestValue < pivotIndex)
            {
                return QuickSelect(kthLowestValue, leftIndex, (short)(pivotIndex - 1));
            }
            else if(kthLowestValue > pivotIndex)
            {
                return QuickSelect(kthLowestValue, (short)(pivotIndex + 1), rightIndex);
            }
            else
            {
                return arr[pivotIndex];
            }    
        }
  
        public void Print()
        {
            for(short x = 0; x < arr.Length; x++)
            {
                T value = arr[x];

                Console.WriteLine($"Value: {value}, Index: {x}");
            }
        }
    }
}