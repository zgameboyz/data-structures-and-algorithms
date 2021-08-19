using DataStructures;
using System;

namespace DataStructures
{
  class Program : QuickSort
  {
    static void Main(string[] args)
    {
      int[] arr = { 2, 6, 8, 7, 1,9,10,58 };




      QuicksortArray(arr, 0, arr.Length - 1);


      for (int i = 0; i < arr.Length; i++)
      {
        Console.WriteLine(arr[i]);
      }




      //for (int i =0; i <arr.Length; i++) {


      //  Console.WriteLine(sorted[i]);

      //}
      //BinaryTree<int> tree = new BinaryTree<int>();

      //Node<int> One = new Node<int>(2);
      //Node<int> Two = new Node<int>(7);
      //Node<int> Three = new Node<int>(5);
      //Node<int> Four = new Node<int>(2);
      //Node<int> Five = new Node<int>(6);
      //Node<int> Six = new Node<int>(9);
      //Node<int> Seven = new Node<int>(5);
      //Node<int> Eight = new Node<int>(11);
      //Node<int> Nine = new Node<int>(4);
      //tree.Root = One;
      //One.Left = Two;
      //One.Right = Three;
      //Two.Left = Four;
      //Two.Right = Five;
      //Three.Right = Six;
      //Five.Left = Seven;
      //Five.Right = Eight;
      //Six.Left = Nine;

      //List<int> list = LevelOrderTraversal(tree);
      //foreach (int num in list)
      {
        //Console.Write($"{num} ");
      }
    }
  }
}
