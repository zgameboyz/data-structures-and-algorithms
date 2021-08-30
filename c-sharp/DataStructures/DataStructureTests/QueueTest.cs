using Xunit;

namespace DataStructuresTest
{
  public class QueueTest : DataStructures.Queue<int>
    {
        [Fact]
        public void AddToQueue()
        {
            DataStructures.Queue<int> queue = new DataStructures.Queue<int>();

            queue.Enqueue(5);

            Assert.Equal(5, queue.Front.Value);
        }

        [Fact]
        public void AddMultipleToQueue()
        {
            DataStructures.Queue<int> queue = new DataStructures.Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Assert.Equal(5, queue.Front.Value);
            queue.Dequeue();
            Assert.Equal(3, queue.Front.Value);
            queue.Dequeue();
            Assert.Equal(4, queue.Front.Value);
        }

        [Fact]
        public void CanEmptyQueue()
        {
            DataStructures.Queue<int> queue = new DataStructures.Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.Null(queue.Front);
        }
    }
}
