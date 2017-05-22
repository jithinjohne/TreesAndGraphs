using System.Collections.Generic;
using Xunit;

namespace TreesAndGraphs.Tests
{
    public class BinarySearchTreeTests
    {
        /// <summary>
        ///     50
        ///  20      75
        /// 5,25    66,80
        /// </summary>
        private BinaryTree<int> SampleBinaryTree()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Root = new BinaryTreeNode<int>(50);
            binaryTree.Root.Left = new BinaryTreeNode<int>(20);
            binaryTree.Root.Right = new BinaryTreeNode<int>(75);
            binaryTree.Root.Left.Left = new BinaryTreeNode<int>(5);
            binaryTree.Root.Left.Right = new BinaryTreeNode<int>(25);
            binaryTree.Root.Right.Left = new BinaryTreeNode<int>(66);
            binaryTree.Root.Right.Right = new BinaryTreeNode<int>(80);
            return binaryTree;
        }


        [Fact]
        public void PreOrderTraversal()
        {
            BinaryTree<int> binaryTree = SampleBinaryTree();

            var expected = new List<int>
            {
                50, 20, 5, 25, 75, 66, 80
            };

            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.PreOrderTraversal(binaryTree.Root);
            var actual = binarySearchTree.Result;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InOrderTraversal()
        {
            BinaryTree<int> binaryTree = SampleBinaryTree();

            var expected = new List<int>
            {
                5, 20, 25, 50, 66, 75, 80
            };

            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InOrderTraversal(binaryTree.Root);
            var actual = binarySearchTree.Result;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PostOrderTraversal()
        {
            BinaryTree<int> binaryTree = SampleBinaryTree();

            var expected = new List<int>
            {
                5, 25, 20, 66, 80, 75, 50
            };

            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.PostOrderTraversal(binaryTree.Root);
            var actual = binarySearchTree.Result;

            Assert.Equal(expected, actual);
        }
    }
}
