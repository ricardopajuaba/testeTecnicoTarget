using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string inputString = Console.ReadLine();

        string invertedString = "";

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            invertedString += inputString[i];
        }

        Console.WriteLine("String invertida: " + invertedString);
    }
}
