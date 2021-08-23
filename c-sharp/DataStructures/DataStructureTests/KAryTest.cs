using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class KaryTest
  {
    [Fact]
    public void Test1()
    {
      KaryTree<int> k = new KaryTree<int>(10);
      k.Root.Value = 10;
      k.Root.Children.Add(new Node<int>(10));
      k.Root.Children.Add(new Node<int>(3));
      k.Root.Children.Add(new Node<int>(15));
      KaryTree<string> res = k.FizzBuzz(k);
      Assert.Equal("buzz", res.Root.Value);
    }
  }
}
