using System;
using System.Diagnostics;

namespace TreesAndGraphs
{
    public class BinarySearchTree<T>
    {
        public void PreOrderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                Trace.WriteLine(current.Value());
                PreOrderTraversal(current.Left);
                PreOrderTraversal(current.Right);
            }
        }
    }
}
