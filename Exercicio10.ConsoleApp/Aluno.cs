using System;

namespace Exercicio10.ConsoleApp
{
    public class Aluno
    {
        public string nome;
        public decimal notaProva1;
        public decimal notaProva2;
        public decimal pesoProva1;
        public decimal pesoProva2;

        public decimal ObterMediaPonderada()
        {
            //A média ponderada é aquela com pesos em cada valor.
            //Portanto basta multiplicar cada valor pelo seu peso e somar os resultados.
            //Depois disso, faremos a divisão desta valor pela soma dos pesos;
            return ((notaProva1 * pesoProva1) + (notaProva2 * pesoProva2)) / (pesoProva1 + pesoProva2);
        }
    }
}