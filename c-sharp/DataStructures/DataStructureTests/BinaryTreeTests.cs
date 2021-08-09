using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructureTests
{
  public class BinaryTreeTests : BinaryTree<int>
  {
    //Help from miriam
    [Fact]
    public void CanMakeEmptyTree()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int>(1);
      Assert.Equal(1, tree.Root.Value);
    }
   
      [Fact] public void CanAddLeftAndRightNode()
    { BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int>(1);
      tree.Root.Left = new Node<int>(6);
      tree.Root.Right = new Node<int>(10);
      Assert.Equal(6, tree.Root.Left.Value);
      Assert.Equal(10, tree.Root.Right.Value);
    }


  }
}
