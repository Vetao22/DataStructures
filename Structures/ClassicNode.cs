namespace DataStructures.Structures
{
    public class ClassicNode<T>
    {
        public T Data { get; set; }
        public ClassicNode<T> Next { get; set; }
        public ClassicNode<T> Previous { get; set; }
      
        public ClassicNode(T data, ClassicNode<T> next = null, ClassicNode<T> previous = null)
        {
            this.Data = data;
            this.Next = next;
            this.Previous = previous;
        }
    }
}