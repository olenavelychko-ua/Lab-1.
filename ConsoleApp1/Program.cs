using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bubble sort");
        Console.Write("Enter your array: ");
        var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        var array = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            array[i] = Convert.ToInt32(parts[i]);
        }
        Console.WriteLine("Sorted array: {0}", string.Join(", ", Bubble_Sort.BubbleSort(array)));
        Console.ReadLine();
    }

}
