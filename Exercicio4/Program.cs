using System;
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.Write("Multiplicando: ");
                int multiplicando = int.Parse(Console.ReadLine());
                if (multiplicando>1000){
                    throw new Exception("O multiplicando não deve ser maior do que 1000.");
                }
                Console.Write("Inicio do intervalo: ");
                int inicio = int.Parse(Console.ReadLine());
                Console.Write("Fim do intervalo: ");
                int fim = int.Parse(Console.ReadLine());
                int diferenca = fim - inicio;
                if (inicio < 0 || fim <0){
                    throw new Exception("Tanto o inicio quanto o fim do intervalo dever ser positivos.");
                }
                if (inicio>1000 || fim >1000){
                    throw new Exception("Tanto o inicio quanto o fim não podem ser maiores do que 1000.");
                }
                if (diferenca <= 0){
                    throw new Exception("O início do intervalo deve ser menor do que o seu fim.");
                }
                if (diferenca > 9){
                    throw new Exception("O intervalo não pode ter uma diferença maior que 10.");
                }

                for (int i = inicio; i <= fim ; i++){
                    Console.WriteLine($"{multiplicando} x {i} = {multiplicando * i}");
                }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
