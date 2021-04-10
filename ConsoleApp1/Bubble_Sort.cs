using System;
public class Bubble_Sort
{
    public int[] array_1;
    public Bubble_Sort(int[] array_1)
    {
        this.array_1 = array_1;
    }
    //метод обміну елементів
    public static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }

    //сортування бульбашкою
     public static int[] BubbleSort(int[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        return array;
    }
}