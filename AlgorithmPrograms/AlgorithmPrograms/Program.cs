// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcom To Data Structure & Algorithms ******************");
using AlgorithmPrograms;
Console.Write("Select Number:\n1)BinarySearch\n2)InsertionSort\n3)BubbleSort");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        BinarySearch bs = new BinarySearch();
        bs.binarysearch();
        break;
    case 2:
        InsertionSort insertionSort = new InsertionSort();
        insertionSort.Insert();
        break;
    case 3:
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Bubblesort();
        break;


        break;

    default:
        Console.WriteLine("Invalid Option");
        break;
}