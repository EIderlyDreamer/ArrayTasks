using System;

class Program
{
    static void Main()
    {

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

 
        Console.WriteLine("Нечетные числа массива: ");
        foreach (int num in arr)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }
    }
}
