using System;
using exercicio4.Controllers;

namespace exercicio4 {
    class Program {
        static void Main (string[] args) {
            CalculadoraController calculadora = new CalculadoraController ();
            CalculadoraCientificaController calculadoraCientifica = new CalculadoraCientificaController ();

            Console.Clear ();
            
            Console.WriteLine ("Escolha uma calculadora: \n 1 - Calculadora Simples \n 2 - Calculadora Científica");
            string escolha = Console.ReadLine ();

            switch (escolha) {
                case "1":
                    calculadora.Escolha();
                    break;
                case "2":
                    calculadoraCientifica.MenuCalculadora();
                    break;
                default:
                    System.Console.WriteLine ("Opção inválida!");
                    break;
            }

        }
    }
}