using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    class FaturamentoDiario
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    static void Main()
    {
        string json = File.ReadAllText("faturamento.json");
        List<FaturamentoDiario> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

        double menor = double.MaxValue, maior = double.MinValue, soma = 0;
        int diasComFaturamento = 0, diasAcimaDaMedia = 0;

        foreach (var dia in faturamento)
        {
            if (dia.Valor > 0)
            {
                if (dia.Valor < menor) menor = dia.Valor;
                if (dia.Valor > maior) maior = dia.Valor;
                soma += dia.Valor;
                diasComFaturamento++;
            }
        }

        double media = soma / diasComFaturamento;

        foreach (var dia in faturamento)
        {
            if (dia.Valor > media)
                diasAcimaDaMedia++;
        }

        Console.WriteLine($"Menor faturamento: {menor}");
        Console.WriteLine($"Maior faturamento: {maior}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
