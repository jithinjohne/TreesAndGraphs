namespace TreesAndGraphs
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTreeNode<T> Root
        {
            get { return root; }
            set { root = value; }
        }
    }
}
