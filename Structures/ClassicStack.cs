using System.Data.SqlTypes;
using System.Runtime.InteropServices.ComTypes;
using System;

namespace DataStructures.Structures
{
    public class ClassicStack<T>
    {
        T[] arr = new T[0];

        public void Push(T value)
        {
            if(value != null)
            {
                T[] tempArr = new T[arr.Length + 1];

                for(short x = 0; x < arr.Length; x++)
                {
                    tempArr[x] = arr[x];
                }
                tempArr[tempArr.Length - 1] = value;
                arr = tempArr;
            }
        }    

        public T Pop()
        {
            T value = default;
            if(arr.Length > 0)
            {
                T[] tempArr = new T[arr.Length - 1];

                for(short x = 0; x < tempArr.Length; x++)
                {
                    value = arr[x];
                    tempArr[x] = arr[x];
                }
                arr = tempArr;
            }

            return value != null ? value: default;
        } 

        public T Read()
        {
            if(arr.Length > 0)
            {
                return arr[arr.Length - 1];
            }
            return default;
        }  
    }
}