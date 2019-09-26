using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salario;
            float vendas;
            double salarioFinal;
            
            Console.Write("Digite seu nome: ");
            nome= Console.ReadLine();
            
            Console.Write("Digite seu salario: R$");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor em reais de vendas: R$");
            vendas = int.Parse(Console.ReadLine());

             salarioFinal=(vendas*0.1)+salario;

             Console.Write("\nNome: "+nome+"\n\nSalario fixo: R$"+salario+"\n\nSalario a receber: R$"+salarioFinal);

             ConsoleColor: while (true);
             {
                 
             }
        }
    }
}
