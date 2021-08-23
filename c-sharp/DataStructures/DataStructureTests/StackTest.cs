using Xunit;

namespace DataStructuresTest
{
  public class StackTest : DataStructures.Stack<int>
  {
    [Fact]
    public void PushToStack()
    {
      DataStructures.Stack<int> stack = new DataStructures.Stack<int>();

      stack.Push(5);

      Assert.True(stack.Peek());
    }

    [Fact]
    public void PushMultipleToStack()
    {
      DataStructures.Stack<int> stack = new DataStructures.Stack<int>();

      stack.Push(5);
      stack.Push(3);
      stack.Push(4);

      Assert.Equal(4, stack.Top.Value);
    }

    [Fact]
    public void CanEmptyStack()
    {
      DataStructures.Stack<int> stack = new DataStructures.Stack<int>();

      stack.Push(5);
      stack.Push(3);
      stack.Push(4);

      stack.Pop();
      stack.Pop();
      stack.Pop();

      stack.Peek();
      Assert.True(stack.IsEmpty());
    }
  }
}
