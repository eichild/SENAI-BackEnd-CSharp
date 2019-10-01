using System;
using exercicio2.Models;

namespace exercicio2.Controllers {
    public class CelularController {
        CelularModel celular = new CelularModel ();
        public void InsereDados () {
            System.Console.WriteLine ("Digite o Modelo do celular: ");
            celular.Modelo = Console.ReadLine ();

            System.Console.WriteLine ("Digite a Cor do celular: ");
            celular.Cor = Console.ReadLine ();

            System.Console.WriteLine ("Digite o tamanho do celular: ");
            celular.Tamanho = float.Parse (Console.ReadLine ());
        }
        public void Ligado () {
            celular.ligado = true;
            System.Console.WriteLine ("Celular Ligado");
        }
        public void Desligado () {
            celular.ligado = false;
            System.Console.WriteLine ("Celular Desligado");
        }

        /// <summary>
        /// Método para verificar se o celular está ligado, se estiver executa suas ações
        /// </summary>
        public void AcaoCelular () {
            if (celular.ligado == true) {
                System.Console.WriteLine ("Fazendo ligação");
                System.Console.WriteLine ("Enviando mensagem");
            } else {
                System.Console.WriteLine ("Celular está desligado!!!");
            }
        }
    }
}