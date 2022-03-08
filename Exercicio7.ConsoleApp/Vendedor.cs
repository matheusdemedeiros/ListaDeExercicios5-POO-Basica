using System;

namespace Exercicio7.ConsoleApp
{
    internal class Vendedor
    {
        public decimal salarioBase;
        public decimal totalDeVendas;
        public decimal percentualDeComissoes;

        private decimal ObterValorDaComissao()
        {
            return (totalDeVendas * percentualDeComissoes) / 100;
        }

        public decimal ObterSalario()
        {
            return salarioBase + ObterValorDaComissao();
        }
    }
}