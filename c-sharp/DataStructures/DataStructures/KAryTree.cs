using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  class KAryTree<T>
  {
    public Node<T> Root { get; set; }

    public static KAryTree<string> FizzBuzzTree(KAryTree<int> tree)
    {
      List<int> numbers = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

     
     

      nodes.Dequeue();

     




        KAryTree<string> fizzTree = new KAryTree<string>();

      return fizzTree;
    }
  }
}
