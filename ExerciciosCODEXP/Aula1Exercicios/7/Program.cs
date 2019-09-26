using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passageiros;
            double resultado;

            Console.Write("Digite a quantidade de passageiros :");
            passageiros=int.Parse(Console.ReadLine());

            resultado=passageiros*4.30;

            Console.Write("Você arrecadou ao final : "+resultado);
        }
    }
}
