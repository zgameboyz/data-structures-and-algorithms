using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class QuickSort
  {

    public static void QuicksortArray(int[] arr, int left, int right)
    {
      if (left < right)
      {
        int position = Partition(arr, left, right);

        QuicksortArray(arr, left, position - 1);

        QuicksortArray(arr, position + 1, right);

      }

      }
    public static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];

      int low = left - 1;

      for (int i = left; i < right; i++)
      {
        if (arr[i] <= pivot)
        {
          low++;
          Swap(arr, i, low);
        }
        
      }
      Swap(arr, right, low + 1);

      return low + 1;
    }
    public static void Swap(int[] arr, int i, int low)
    {
      int temp;
      temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
    }
  }
}
