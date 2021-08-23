using DataStructures;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructuresTest
{
  public class LevelOrderTraversalTest : BinaryTree<int>
  {
    [Fact]
    public void LevelOrderTraversalTesting()
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      Node<int> One = new Node<int>(2);
      Node<int> Two = new Node<int>(7);
      Node<int> Three = new Node<int>(5);
      Node<int> Four = new Node<int>(2);
      Node<int> Five = new Node<int>(6);
      Node<int> Six = new Node<int>(9);
      Node<int> Seven = new Node<int>(5);
      Node<int> Eight = new Node<int>(11);
      Node<int> Nine = new Node<int>(4);

      tree.Root = One;
      One.Left = Two;
      One.Right = Three;
      Two.Left = Four;
      Two.Right = Five;
      Three.Right = Six;
      Five.Left = Seven;
      Five.Right = Eight;
      Six.Left = Nine;

      List<int> list = LevelOrderTraversal(tree);
      foreach (int num in list)
      {
        Console.Write($"{num} ");
      }

      Assert.Equal(list, LevelOrderTraversal(tree));
    }
  }
}
