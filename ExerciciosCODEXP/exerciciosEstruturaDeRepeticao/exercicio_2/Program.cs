using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que mostre o resultado da tabuada de um número inteiro dado pelo usuário.
            int num,res;
            
            Console.Write("Digite o numero que deseja mostrar a tabuada: ");
            num=int.Parse(Console.ReadLine());

            for(int i=0; i<=10;i++){
                res=num*i;
                Console.WriteLine(num+" X "+i+ " = "+res);
            }
        }
    }
}
