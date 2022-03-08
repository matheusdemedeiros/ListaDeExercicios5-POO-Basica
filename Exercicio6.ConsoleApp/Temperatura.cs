using System;

namespace Exercicio6.ConsoleApp
{
    /*
    °F = °C × 1, 8 + 32
    °C = (°F − 32) ÷ 1, 8
    */
    internal class Temperatura
    {
        public double grausCelsius;

        public double ObterEmFahrenheit()
        {
            return grausCelsius * 1.8f  + 32f;
        }
    }
}