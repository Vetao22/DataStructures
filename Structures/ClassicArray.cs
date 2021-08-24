using System;

namespace DataStructures.Structures
{
    public class ClassicArray<T> where T: IComparable<T>
    {
        T[] arr = new T[0];
       

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

        public void Remove(T valueToRemove)
        {
            short index = LinearSearch(valueToRemove);

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
                }

                arr = temp;
            }
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