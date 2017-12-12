using System;
using StrategySample.Delivery;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaFrete calculaFrete = new CalculaFrete("ctt");
            Console.WriteLine(calculaFrete.Calcular(100).ToString());
            calculaFrete = new CalculaFrete("correios");
            Console.WriteLine(calculaFrete.Calcular(100).ToString());
             calculaFrete = new CalculaFrete("fedex");
            Console.WriteLine(calculaFrete.Calcular(100).ToString());
            Console.ReadKey();
        }
    }
}
