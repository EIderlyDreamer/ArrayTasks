using System;

class Program
{
    static void Main()
    {
        string[] arr = { "автобус", "яблоко", "компьютер", "календарь", "телефон" };
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        bool found = false;
        foreach (string str in arr)
        {
            if (str == input)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Строка найдена");
        }
        else
        {
            Console.WriteLine("Строка не найдена");
        }
    }
}