using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27QMSSort
{
    public class QuickSort
    {
        static void Swap(int[] arr, int i, int j) { int temp = arr[i]; arr[i] = arr[j]; arr[j] = temp; }
        static int Partition(int[] arr, int low, int high)// UpperBond is hogh, lowerbound low
        {
            int pivot = arr[high]; int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {// in case current element is smaller than pivot
                if (arr[j] < pivot)
                {//increment index of smaller element 
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }
        //write that implement Quick Sort
        static void QuickSortFun(int[] arr, int low, int high)
        {
            if (low < high)//  partition with index
            {
                int p = Partition(arr, low, high);
                //separately sort element before partion and after partion
                QuickSortFun(arr, low, p - 1);
                QuickSortFun(arr, p + 1, high);
            }
        }
        static void Print(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
                // QuickSortFun(arr, 0, n - 1);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 9, 5, 2, 3 };
            int n = arr.Length;
            QuickSortFun(arr, 0, n - 1);
            Print(arr, n);
        }
    }
}

