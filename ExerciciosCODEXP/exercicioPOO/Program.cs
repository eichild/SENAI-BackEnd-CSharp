using System;
using exercicioPOO.Controllers;

namespace exercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaControllers ObjPessoa = new PessoaControllers();

            Console.Clear();
            ObjPessoa.RecebeDados();
            ObjPessoa.ImprimeDados();
            ObjPessoa.CalculaIMC();
           
        }
    }
}
