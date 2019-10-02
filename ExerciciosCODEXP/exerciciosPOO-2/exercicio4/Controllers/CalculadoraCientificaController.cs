using System;
using exercicio4.Models;

namespace exercicio4.Controllers {
  public class CalculadoraCientificaController : CalculadoraController {
    CalculadoraCientificaModel calculadoraCientifica = new CalculadoraCientificaModel ();
    double num1, num2, escolha;
    public void MenuCalculadora () {
      try {
        System.Console.WriteLine ("Dígite a operação desejada - \n 1. Soma \n 2. Subtração  \n 3. Divisão \n 4. Multiplicação \n 5. Potencia");
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

          case 5:
            Potencia ();
            break;

          default:
            System.Console.WriteLine ("Erro no processamento");
            break;
        }
      } catch (Exception ex) {
        System.Console.WriteLine ("ERRO NA APLICAÇÃO");
      }
    }
    public void Potencia () {
      System.Console.WriteLine ("Digite o primeiro numero: ");
      num1 = int.Parse (Console.ReadLine ());
      System.Console.WriteLine ("Digite o segundo numero para ser elevado");
      num2 = int.Parse (Console.ReadLine ());
      calculadoraCientifica.potencia = 0;
      calculadoraCientifica.potencia = Math.Pow (num1, num2);
      System.Console.WriteLine (calculadoraCientifica.potencia);
    }
  }
}