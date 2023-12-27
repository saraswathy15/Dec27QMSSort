using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27QMSSort
{
    public class ShellSortEx
    {
        static void Swap(ref int a, ref int b)
        { var t = a; a = b; b = t; }
        static int[] ShellSort(int[] arr)
        {
            var d = arr.Length - 1;//total lenght distance
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && arr[j - d] > arr[j])
                    {
                        Swap(ref arr[j], ref arr[j - d]);
                        j = j - d;
                    }//while 
                }// for loop
                d = d / 2;
            }
            return arr;
        }
        //static int ShellSort(int[] arr)
        //{
        //    int len = arr.Length;
        //    for (int h = len/2;h>0;h /= 2)//if 10 values h is 5
        //    {
        //        for(int i= h;i<len;i += i)
        //        {
        //            int temp = arr[i];// temp will have 5
        //            int j;
        //            for(j=i;j>=h && arr[j-h]> temp; j  -= h)
        //            {
        //                arr[j] = arr[j-h];

        //            }// 3 for loop
        //            arr[j] = temp;
        //        }//2 for loop 
        //    }// 1 for 
        //    return 0;
        //}// sort 
        //static void PrintShellSort(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(" enter  array values");
            //  int[] arr = { 8, 3, 99, 45, 200, 10, 1 };
            var s = Console.ReadLine().Split(new[] { "", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = Convert.ToInt32(s[i]);
                // Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Sorted array: {0}", string.Join(",", ShellSort(arr)));

            Console.ReadLine();

            //  PrintShellSort(arr);
            //  ShellSort(arr);
            // PrintShellSort(arr);

        }
    }
}

