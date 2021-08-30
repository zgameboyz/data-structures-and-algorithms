using Xunit;

namespace DataStructuresTest
{
  public class QuickSortTest : DataStructures.QuickSort
    {
        [Fact]
        public void CanSort()
        {
            int[] arr = { 2, 6, 8, 7, 1, 9, 10, 58 };

            QuicksortArray(arr, 0, arr.Length - 1);

            Assert.Equal(1, arr[0]);
            Assert.Equal(2, arr[1]);
            Assert.Equal(6, arr[2]);
            Assert.Equal(7, arr[3]);
            Assert.Equal(8, arr[4]);
            Assert.Equal(9, arr[5]);
            Assert.Equal(10, arr[6]);
            Assert.Equal(58, arr[7]);
        }

        [Fact]
        public void CanHaveNegatives()
        {
            int[] arr = { -2, 6, 8, 7, -1, 9, 10, 58 };

            QuicksortArray(arr, 0, arr.Length - 1);

            Assert.Equal(-2, arr[0]);
            Assert.Equal(-1, arr[1]);
            Assert.Equal(6, arr[2]);
            Assert.Equal(7, arr[3]);
            Assert.Equal(8, arr[4]);
            Assert.Equal(9, arr[5]);
            Assert.Equal(10, arr[6]);
            Assert.Equal(58, arr[7]);
        }
    }
}
