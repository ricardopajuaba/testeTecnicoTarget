using System;

class Program
{
    static void Main()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        // Laço para somar os números de 1 até 13
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        // Exibe o resultado da soma
        Console.WriteLine("O valor de SOMA ao final do processamento é: " + SOMA);
    }
}

// RESPOSTA DA QUESTÃO: 91