namespace DataStructures.Structures
{
    public class ClassicTreeNode<T>
    {
        public T Data { get; set; }
        public ClassicTreeNode<T> LeftChild { get; set; }
        public ClassicTreeNode<T> RightChild { get; set; }

        public ClassicTreeNode(T data, ClassicTreeNode<T> leftChild = null, 
                                ClassicTreeNode<T> rightChild = null)
        {
            Data = data;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}