using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            float custo;
            float percentual;
            float valorTotal;

            Console.Write("Digite o preço da mercadoria: R$");
            custo=float.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de acrescimo: ");
            percentual=float.Parse(Console.ReadLine());

            valorTotal=(percentual/100)*custo+custo;

            Console.Write("Valor total da mercadoria é: R$"+valorTotal);
        }
    }
}
