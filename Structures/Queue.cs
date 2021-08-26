namespace DataStructures.Structures
{
    public class Queue<T>
    {
          T[] arr = new T[0];

        public void Enqueue(T value)
        {
            if(value != null)
            {
                T[] tempArr = new T[arr.Length + 1];

                for(short x = 0; x < arr.Length; x++)
                {
                    tempArr[x] = arr[x];
                }
                tempArr[tempArr.Length - 1] = value;
            }
        }    

        public T Dequeue()
        {
            if(arr.Length > 0)
            {
                T value = arr[0];

                T[] tempArr = new T[arr.Length - 1];

                for(short x = 1; x < arr.Length; x++)
                {
                    tempArr[x - 1] = arr[x];
                }

                return value;
            }

            return default;
        } 

        public T Read()
        {
            if(arr.Length > 0)
            {
                return arr[0];
            }
            return default;
        }  
    }
}