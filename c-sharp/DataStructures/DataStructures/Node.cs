using System.Collections.Generic;

namespace DataStructures
{
  public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        //Can this go here? unclear
        //public Node Head { get; set; }

        public Node(T value)
        {
            Children = new List<Node<T>>();
            Value = value;
        }
    }
}
