using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que gere 20 números da série Fibonacci (0, 1, 1, 2, 3, 5, 8, 13, 21...).
            int num1=0;
            int num2=1;

            for(int i=1;i<=10;i++){
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                num1+=num2;
                num2+=num1;
            }
        }
    }
}
