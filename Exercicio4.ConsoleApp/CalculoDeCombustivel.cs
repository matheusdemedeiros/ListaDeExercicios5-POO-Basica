using System;

namespace Exercicio4.ConsoleApp
{
    internal class CalculoDeCombustivel
    {
        public double quantidadeDeCombustivelComOhTanqueCheio;
        public double quantidadeDeCombustivelNoTanqueDepoisDoPercurso;
        public double kilometragemFinal;
        public double kilometragemInicial;

        public double ObterConsumo()
        {
            double distanciaPercorrida = kilometragemFinal - kilometragemInicial;
            double diferencaDeCombustivel = quantidadeDeCombustivelComOhTanqueCheio - quantidadeDeCombustivelNoTanqueDepoisDoPercurso;
            return distanciaPercorrida / diferencaDeCombustivel;
        }
    }
}