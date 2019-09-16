using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            float media;
            bool resultado = false;
            string nomeAluno;

            Console.WriteLine("\nBem vindos à nossa primeira aplicação");

            Console.Write("Digite");
            Console.Write(" seu nome ");
            
           nomeAluno= Console.ReadLine();
           Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota: ");
            
            //Convertendo numero inteiro para ser lido
            num1 = int.Parse(Console.ReadLine());

            //Interpolação
            Console.WriteLine($"Sua primeira nota é {num1}");

            Console.WriteLine("Digite sua segunda nota");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua terceira nota");
            num3 =  int.Parse(Console.ReadLine());

            media=(num1+num2+num3)/3;

            Console.WriteLine("Sua média é : " +media); 
        }
    }
}
