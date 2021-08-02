namespace Exercicio3
{
    public class ICMS:IImposto
    {
        public double CalculaImposto(double valor){
            double imposto;
            imposto = valor * 0.27;
            return imposto;
        }
    }
}