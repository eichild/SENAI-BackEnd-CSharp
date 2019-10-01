using System;
using exercicio4.Models;

namespace exercicio4.Controllers {
    public class CalculadoraController {
        CalculadoraModel calculadora = new CalculadoraModel ();
        int num1, num2;
        int escolha;
        public void InsereDados () {
            System.Console.WriteLine ("Digite o primeiro numero que deseja fazer as contas: ");
            num1 = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo numero que deseja fazer as contas: ");
            num2 = int.Parse (Console.ReadLine ());
        }
        public void Escolha () {
            System.Console.WriteLine ("Dígite a operação desejada - \n 1. Soma \n 2. Subtração  \n 3. Divisão \n 4. Multiplicação \n 5. Potenciação");
            escolha = int.Parse (Console.ReadLine ());

            switch (escolha) {
                case 1:
                    InsereDados ();
                    Soma ();
                    break;

                case 2:
                    InsereDados ();
                    Subtracao ();
                    break;

                case 3:
                    InsereDados ();
                    Divisao ();
                    break;

                case 4:
                    InsereDados ();
                    Multiplicacao ();
                    break;

                default:
                    System.Console.WriteLine ("Erro no processamento");
                    break;
            }
        }
        public void Soma () {
            calculadora.Soma = num1 + num2;
            System.Console.WriteLine (calculadora.Soma);
        }
        public void Subtracao () {
            calculadora.Subtracao = num1 - num2;
            System.Console.WriteLine (calculadora.Subtracao);
        }
        public void Divisao () {
            calculadora.Divisao = num1 / num2;
            System.Console.WriteLine (calculadora.Divisao);
        }
        public void Multiplicacao () {
            calculadora.Multiplicacao = num1 * num2;
            System.Console.WriteLine (calculadora.Multiplicacao);
        }

    }
}