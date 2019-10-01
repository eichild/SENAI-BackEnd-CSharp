using System;
using exercicio4.Controllers;

namespace exercicio4 {
    class Program {
        static void Main (string[] args) {
            CalculadoraCientificaController objCalculadora = new CalculadoraCientificaController ();

            Console.Clear ();
            objCalculadora.Escolha();
            
        }
    }
}