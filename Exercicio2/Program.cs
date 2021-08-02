using System;


namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(0,7);
            bool i = false;
            Console.Write("Digite um número entre 0 e 7: ");
            while (!i){
                
                int tentativa = int.Parse(Console.ReadLine());
                if (tentativa == numero){
                    Console.WriteLine($"Parabéns você acertou, o número era {numero}!");
                    i = true;
                }
                else{
                    Console.WriteLine("Número errado, tente de novo.");
                }
            }

        }
    }
}
