// See https://aka.ms/new-console-template for more information
//Console.WriteLine("**************** Welcom To Data Structure & Algorithms ******************");
using AlgorithmPrograms;
Console.Write("Select Number:\n1)BinarySearch");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        BinarySearch bs = new BinarySearch();
        bs.binarysearch();
        break;

    default:
        Console.WriteLine("Invalid Option");
        break;
}