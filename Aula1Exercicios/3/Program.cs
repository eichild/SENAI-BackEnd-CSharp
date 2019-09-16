using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float vendas;
            double resultado;
            
            Console.Write("Digite seu salario: R$");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor em reais de vendas: R$");
            vendas = int.Parse(Console.ReadLine());

            resultado=(vendas*0.05)+salario;
            Console.Write("O total a receber é: R$"+resultado);
        }
    }
}
