using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoTotal;

            Console.Write("Digite o preço total: ");
            precoTotal=float.Parse(Console.ReadLine());

            if(precoTotal>=100 && precoTotal<=1000){
                precoTotal = precoTotal*0.15;
            }
            Console.Write("Preco Total "+precoTotal);
        }
    }
}
