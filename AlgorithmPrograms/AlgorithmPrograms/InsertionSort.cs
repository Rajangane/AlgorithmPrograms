using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Insert()
        {
            string sampledemo = "trust timing of your life";
            string[] names = sampledemo.Split(" ");
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {

                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }   
}
