namespace Exercicio1.ConsoleApp
{
    public class Caixa
    {
        public decimal altura;
        public decimal largura;
        public decimal cumprimento;

        public decimal ObterVolume()
        {
            return altura * largura * cumprimento;
        }
    }
}


