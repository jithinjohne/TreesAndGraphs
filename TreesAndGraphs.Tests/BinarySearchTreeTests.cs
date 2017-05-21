using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TreesAndGraphs.Tests
{
    public class BinarySearchTreeTests
    {
        /// <summary>
        ///     50
        /// 20      75
        /// 5,25    66,80
        /// </summary>
        [Fact]
        public void PreOrderTraversal()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Root = new BinaryTreeNode<int>(50);
            binaryTree.Root.Left = new BinaryTreeNode<int>(20);
            binaryTree.Root.Right = new BinaryTreeNode<int>(75);
            binaryTree.Root.Left.Left = new BinaryTreeNode<int>(5);
            binaryTree.Root.Left.Right = new BinaryTreeNode<int>(25);
            binaryTree.Root.Right.Left = new BinaryTreeNode<int>(66);
            binaryTree.Root.Right.Right = new BinaryTreeNode<int>(80);

            var binarySearchTree = new BinarySearchTree<int>();

            binarySearchTree.PreOrderTraversal(binaryTree.Root);

        }
    }
}
