using System;

namespace Exercicio3.ConsoleApp
{
    public class Cilindro
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