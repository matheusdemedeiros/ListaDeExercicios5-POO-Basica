using System;

namespace Exercicio8.ConsoleApp
{
    public class LataDeOleo
    {
        public double raio;
        public double altura;

        public double ObterVolume()
        {
            //V = π.r2.h
            return (Math.PI * Math.Pow(raio, 2)) * altura;
        }
    }
}
