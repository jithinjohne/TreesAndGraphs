namespace TreesAndGraphs
{
    public class BinaryTreeNode<T>
    {
        private T data;

        public BinaryTreeNode()
            : this(default(T), null, null)
        { }

        public BinaryTreeNode(T data)
            : this(data, null, null)
        { }

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public T Data
        {
            get { return data; }
            private set { data = value; }
        }

        private BinaryTreeNode<T> left;

        public BinaryTreeNode<T> Left
        {
            get { return left; }
            set { left = value; }
        }
        private BinaryTreeNode<T> right;

        public BinaryTreeNode<T> Right
        {
            get { return right; }
            set { right = value; }
        }

    }
}
