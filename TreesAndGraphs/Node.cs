using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndGraphs
{
    public class Node<T>
    {
        public Node(T data, IList<Node<T>> neighbors)
        {
            Data = data;
            Neighbors = neighbors;
        }
        public Node(T data) : this(data, null)
        {
        }
        public Node()
        {

        }
        public T Data { get; set; }
        public IList<Node<T>> Neighbors { get; set; }
    }
}
