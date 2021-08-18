using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructureTests
{
  public class PseudoQueueTest : DataStructures.PseudoQueue<int>
  {
    //Help from miriam
    [Fact]
    public void CanEnqueue()
    {
      DataStructures.Queue<int> queue = new DataStructures.Queue<int>();
      queue.Enqueue(5);
      Assert.Equal(5, queue.Front.Value);
    }
   
     [Fact]
    public void CanDequeue()
    {
    
      DataStructures.Queue<int> queue = new DataStructures.Queue<int>();
      queue.Enqueue(5);
      queue.Dequeue();

      Assert.Null(queue.Front);
    }
  }
}
