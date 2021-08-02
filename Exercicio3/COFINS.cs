namespace Exercicio3
{
    public class COFINS : IImposto
    {
        public double CalculaImposto(double valor){
            double imposto;
            if (valor > 13000){
                imposto = valor * 0.04;
            } 
            else{
                imposto = 0;
            }
            return imposto;
        }

    }
}