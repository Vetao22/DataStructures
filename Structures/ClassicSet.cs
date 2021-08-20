using System;
using System.Collections.Generic;

namespace DataStructures.Structures
{
    public class ClassicSet<T>
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
            if(!IsValueInArray(value))
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
            return LinearSearch(value);
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
    
        bool IsValueInArray(T value)
        {
            foreach(T v in arr)
            {
                if(v.Equals(value))
                {
                    return true;
                }
            }
            return false;
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