using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;
            float resultado;
            float dolar;

            Console.Write("Digite o valor em reais para conversão: R$");
            valor = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor do dolar atual: $");
            dolar= float.Parse(Console.ReadLine());

            resultado=valor/dolar;

            Console.Write("O valor da conversão é: $"+resultado);
        }
    }
}
