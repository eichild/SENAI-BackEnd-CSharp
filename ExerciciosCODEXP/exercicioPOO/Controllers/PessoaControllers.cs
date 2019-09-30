using System;
using System.IO;
using exercicioPOO.Models;

namespace exercicioPOO.Controllers {
    public class PessoaControllers {
        PessoaModel pessoa = new PessoaModel ();

        public void RecebeDados () {
            try {
                System.Console.WriteLine ("Digite seu Nome: ");
                pessoa.Nome = Console.ReadLine ();

                System.Console.WriteLine ("Digite sua Idade: ");
                pessoa.Idade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite seu Peso: ");
                pessoa.Peso = double.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite sua Altura: ");
                pessoa.Altura = double.Parse (Console.ReadLine ());
            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe, Ocorreu um Erro na Aplicação");
                SalvarErros (ex);
            }
        }
        public void CalculaIMC () {
            double resIMC;
            resIMC = pessoa.Peso / Math.Pow (pessoa.Altura, 2);

            if (resIMC <= 18.5) {
                System.Console.WriteLine ("---Você está abaixo do peso---");
            } 
            else if (resIMC >= 18.5 && resIMC <= 25) {
                System.Console.WriteLine ("---Você está com Peso Normal---");
            } 
            else if (resIMC >= 26 && resIMC <= 30) {
                System.Console.WriteLine ("---Você está com Sobrepeso---");
            } 
            else if (resIMC >= 31 && resIMC <= 35) {
                System.Console.WriteLine ("---Você está com Obesidade Grau 1---");
            } 
            else if (resIMC >= 36 && resIMC <= 39) {
                System.Console.WriteLine ("---Você está com Obesidade Grau 2---");
            } 
            else if (resIMC >= 40) {
                System.Console.WriteLine("---Você está com Obesidade Grau 3---");
            }   

        }
        public void ImprimeDados () {
            System.Console.WriteLine("Nome: "+pessoa.Nome);
            System.Console.WriteLine("Idade: "+pessoa.Idade);
            System.Console.WriteLine("Peso: "+pessoa.Peso);
            System.Console.WriteLine("Altura: "+pessoa.Altura);
            
        }
        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter ("erro_log.txt", true);
            //Escrevendo no Arquivo de erro
            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex + "\n");
            txt.Close ();

        }
    }
}