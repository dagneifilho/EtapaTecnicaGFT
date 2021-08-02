using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> prova = new List<Atleta>();
            for(int i = 1; i < 11; i++){
                Console.Write($"Digite o nome do Atleta {i}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o país do Atleta {i}: ");
                string pais = Console.ReadLine();
                Console.Write($"Digite o resultado (em metros) do Atleta: ");
                double distancia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                prova.Add(new Atleta(nome, pais, distancia));
            }
            List<Atleta> provaOrdenada = prova.OrderBy(atleta => atleta.Distancia).ToList();
            Atleta ouro = provaOrdenada[9];
            Atleta prata = provaOrdenada[8];
            Atleta bronze = provaOrdenada[7];

            Console.WriteLine("Ouro: " + ouro);
            Console.WriteLine("Prata: " + prata);
            Console.WriteLine("Bronze: " + bronze);

        }
    }
}
