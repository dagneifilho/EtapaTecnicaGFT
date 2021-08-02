namespace Exercicio3
{
    public class IPI : IImposto
    {

        public double CalculaImposto(double valor)
        {
            double imposto;
            if (valor < 25000){
                imposto = 0.05 * valor;
            }
            else {
                imposto  = 0.11 * valor;
            }
            return imposto;
        }
    }
}