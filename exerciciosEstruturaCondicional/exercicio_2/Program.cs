using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           double precoTotal;
           
           Console.Write("Escreva o preço total:");
           precoTotal=double.Parse(Console.ReadLine());

            if(precoTotal>100){
                precoTotal= precoTotal - 25;
            }
            Console.Write("Preço a ser pago: "+precoTotal);
        }
    }
}
