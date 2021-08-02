namespace Exercicio1
{
    public class Atleta
    {
        public string Nome;
        public string Pais;
        public double Distancia;
        public Atleta(string nome, string pais, double distancia){
            Nome = nome;
            Pais = pais;
            Distancia= distancia;
        }
        public override string ToString(){
            return Nome +  " - " + Pais + ", Resultado: " + Distancia;
        }
    }
}