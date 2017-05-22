using System;
using System.Collections.Generic;

namespace TreesAndGraphs
{
    public class BinarySearchTree<T>
    {
        private IList<T> result;

        public BinarySearchTree()
        {
            result = new List<T>();
        }

        public void PreOrderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                result.Add(current.Data);
                PreOrderTraversal(current.Left);
                PreOrderTraversal(current.Right);
            }
        }

        public IList<T> Result
        {
            get { return result; }
            private set { result = value; }
        }

        public void InOrderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                InOrderTraversal(current.Left);
                result.Add(current.Data);
                InOrderTraversal(current.Right);
            }
        }

        public void PostOrderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                PostOrderTraversal(current.Left);
                PostOrderTraversal(current.Right);
                result.Add(current.Data);
            }
        }


    }


}
