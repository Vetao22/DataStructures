namespace DataStructures.Structures
{
    public class ClassicQueue<T>
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
                arr = tempArr;
            }
        }    

        public T Dequeue()
        {
            T value = default;
            if(arr.Length > 0)
            {
                value = arr[0];

                T[] tempArr = new T[arr.Length - 1];

                for(short x = 1; x < arr.Length; x++)
                {
                    tempArr[x - 1] = arr[x];
                }
                arr = tempArr;
            }

            return value != null ? value: default;
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