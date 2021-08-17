using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructureTests
{
  public class InsertionSortTest : InsertionSort
  {
    //Help from miriam and Q
    [Fact]
    public void CanSortArray()
    {
      int[] arr = { 2, 6, 8, 7, 1 };
      int[] sorted = InsertionSortArray(arr);

      Assert.Equal(1, sorted[0]);
      Assert.Equal(2, sorted[1]);
      Assert.Equal(6, sorted[2]);
      Assert.Equal(7, sorted[3]);
      Assert.Equal(8, sorted[4]);
    }
    [Fact]
    public void CanSortWithNegatives()
    {
      int[] arr = { 2, 6, -8, 7, -1 };
      int[] sorted = InsertionSortArray(arr);

      Assert.Equal(-8, sorted[0]);
      Assert.Equal(-1, sorted[1]);
      Assert.Equal(2, sorted[2]);
      Assert.Equal(6, sorted[3]);
      Assert.Equal(7, sorted[4]);
    }
  }
}

