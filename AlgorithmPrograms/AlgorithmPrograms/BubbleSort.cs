using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Bubblesort()
        {
            int[] arr = { 100, 55, 200, 16 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1]) //if num > num2 then swap
                    {
                        temp = arr[i + 1];// swap temp and arr[i]
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        Console.WriteLine("Sorted array:");
                        foreach (int p in arr) //print array
                            Console.WriteLine(p + " ");
                    }
                }
            }
        }
    }
}
