using System;
using exercicio1.Controllers;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController objAluno = new AlunoController();

            Console.Clear();
            objAluno.InsereDados();
            objAluno.ImprimeDados();
            
            
        }
    }
}
