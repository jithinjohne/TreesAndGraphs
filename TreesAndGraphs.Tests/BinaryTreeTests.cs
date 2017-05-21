using Xunit;

namespace TreesAndGraphs.Tests
{
    public class BinaryTreeTests
    {
        /// <summary>
        /// Create the following binary tree structure 
        ///         1
        ///     2       3
        ///    4 5     6 7
        /// </summary>
        [Fact]
        public void CanCreate_SimpleBinaryTree()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Root = new BinaryTreeNode<int>(1);
            binaryTree.Root.Left = new BinaryTreeNode<int>(2);
            binaryTree.Root.Right = new BinaryTreeNode<int>(3);
            binaryTree.Root.Left.Left = new BinaryTreeNode<int>(4);
            binaryTree.Root.Left.Right = new BinaryTreeNode<int>(5);
            binaryTree.Root.Right.Left = new BinaryTreeNode<int>(6);
            binaryTree.Root.Right.Right = new BinaryTreeNode<int>(7);


        }
    }
}
