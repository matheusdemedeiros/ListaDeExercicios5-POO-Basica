using System;

namespace Exercicio5.ConsoleApp
{
    public class Esfera
    {
        public double raio;

        public double ObterVolume()
        {
            //V = 4/3 πr³
            //4\/3 * Π * 10³ = 4188,79
            return (4 * Math.PI * Math.Pow(raio, 3)) / 3;
        }
    }
}