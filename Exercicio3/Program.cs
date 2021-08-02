using System;
using System.Globalization;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantia: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            IImposto icms = new ICMS();
            IImposto ipi = new IPI();
            IImposto cofins = new COFINS();

            double impostoICMS = icms.CalculaImposto(valor);
            double impostoIPI = ipi.CalculaImposto(valor);
            double impostoCOFINS = cofins.CalculaImposto(valor);
            double totalImpostos = impostoCOFINS+impostoIPI+impostoICMS;

            Console.WriteLine($"ICMS = {impostoICMS.ToString("C",CultureInfo.CurrentCulture)}");
            Console.WriteLine($"IPI = {impostoIPI.ToString("C",CultureInfo.CurrentCulture)}");
            Console.WriteLine($"COFINS = {impostoCOFINS.ToString("C",CultureInfo.CurrentCulture)}");
            Console.WriteLine($"TOTAL = {totalImpostos.ToString("C",CultureInfo.CurrentCulture)}");
        }
    }
}
