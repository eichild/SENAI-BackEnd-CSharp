using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Digite o primeiro numero: ");
            num1= int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro numero: ");
            num2= int.Parse(Console.ReadLine());

            if(num1>num2){
                Console.Write(num1+" Maior que "+num2);
            }else{
                Console.Write(num2+" Maior que " +num1);
            }
        }
    }
}
