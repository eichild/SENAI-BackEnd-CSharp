using System;
using exercicio4.Models;

namespace exercicio4.Controllers {
    public class CalculadoraController {
        CalculadoraModel calculadora = new CalculadoraModel ();
        int num1, num2, escolha;

        /// <summary>
        /// Método para inserção de dados
        /// </summary>
        public void InsereDados () {
            System.Console.WriteLine ("Digite o primeiro numero que deseja fazer as contas: ");
            num1 = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo numero que deseja fazer as contas: ");
            num2 = int.Parse (Console.ReadLine ());
        }

        public void Escolha () {
            try {
                System.Console.WriteLine ("Dígite a operação desejada - \n 1. Soma \n 2. Subtração  \n 3. Divisão \n 4. Multiplicação");
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
            } catch (Exception ex) {
                System.Console.WriteLine ("ERRO NA APLICAÇÃO!!!");
            }
        }

        //MÉTODOS PARA AS OPERAÇÕES//
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