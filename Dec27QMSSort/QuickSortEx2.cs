using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27QMSSort
{
    public class QuickSortEx2
    {
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];//first element
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;//next
                }
                while (arr[right] > pivot)
                {
                    right--;// previous
                }
                if (left < right)
                {
                    if (arr[left] == arr[right])
                        return right;
                }
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                { return right; }
            }
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 4, 11, 0, 18, 22, 67, 51, 6 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var x in arr)
                Console.WriteLine(x);
        }
    }
}
