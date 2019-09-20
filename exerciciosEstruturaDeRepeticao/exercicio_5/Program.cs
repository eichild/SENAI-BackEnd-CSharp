using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Uma empresa com X funcionários precisa saber a média de seus salários. Faça um
          algoritmo para ler a quantidade de funcionários e o salário de cada um e escrever a
          média dos salários.*/
          
          int funcionarios=0;
          double salario;
          double mediaSalario=0;
          double qtdSalario=0;
          int i=1;

          Console.Write("Digite a quantidade de funcionarios: ");
          funcionarios=int.Parse(Console.ReadLine());

          while(i<=funcionarios){
              Console.Write("Digite o salario do "+i+" Funcionario: ");
              salario=Double.Parse(Console.ReadLine());
              qtdSalario+=salario;
              mediaSalario=qtdSalario/i;
              i++;
          }
          Console.Write(mediaSalario.ToString("F2"));
        }
    }
}
