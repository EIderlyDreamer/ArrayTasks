using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        double avg = (double)sum / arr.Length;
        Console.WriteLine("Среднее значение элементов массива: " + avg);
    }
}