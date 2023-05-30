// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine("Результат функции Аккермана для чисел {0} и {1} равен {2}", m, n, result);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}