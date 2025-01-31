using System;

class Program
{
    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;
        while (a <= n)
        {
            if (a == n)
                return true;
            int temp = a;
            a = b;
            b = temp + b;
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (IsFibonacci(num))
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
    }
}
