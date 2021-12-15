using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void binarysearch()
        {
            string sampleademo = "your mind belives what you keep telling it again and again so tell positive things only";
            string[] Demo = sampleademo.Split(" "); //Seprating a string

            Array.Sort(Demo); // sorting Array in Assending Order

            Console.WriteLine("Enter word you want to search : ");
            string search = Console.ReadLine();
           //this method search value in a one dimensional array
            int i = Array.BinarySearch(Demo, search);//taking index value

            if (i >= 0)
                Console.WriteLine("word found at position " + i + "\n");
            else
                Console.WriteLine("word not found\n");
        }
    }
}
