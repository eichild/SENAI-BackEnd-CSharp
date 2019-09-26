using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int num;
            double resultado;

            Console.WriteLine("Digite seu nome: ");
            nome= Console.ReadLine();
            
            Console.WriteLine("Digite o numero que deseja calcular o triplo: ");
            num= int.Parse(Console.ReadLine());
            resultado= num*3;

            Console.WriteLine("O triplo do numero digitado é: "+resultado);

        }
    }
}
