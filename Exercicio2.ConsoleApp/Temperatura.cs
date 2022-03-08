using System;

namespace Exercicio2.ConsoleApp
{
    /*
     °F = °C × 1, 8 + 32
     °C = (°F − 32) ÷ 1, 8
     */
    public class Temperatura
    {
        public decimal grausFahrenheit;

        public decimal ObterEmCelsius()
        {
            return (grausFahrenheit - 32) / 1.8m;
        }
    }
}
