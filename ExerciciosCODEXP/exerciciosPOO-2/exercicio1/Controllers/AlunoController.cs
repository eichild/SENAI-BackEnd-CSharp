using System;
using System.IO;
using exercicio1.Models;

namespace exercicio1.Controllers {
    public class AlunoController {
        AlunoModel aluno = new AlunoModel ();

        public void InsereDados () {
            try {
                string validarBolsista;
                System.Console.WriteLine ("Digite seu Nome: ");
                aluno.Nome = Console.ReadLine ();

                System.Console.WriteLine ("Digite seu Curso: ");
                aluno.Curso = Console.ReadLine ();

                System.Console.WriteLine ("Digite sua idade: ");
                aluno.Idade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite seu RG: ");
                aluno.Rg = Console.ReadLine ();

                System.Console.WriteLine ("Você é bolsista? ");
                validarBolsista = Console.ReadLine ();
                validarBolsista.ToUpper ();

                validarBolsista = validarBolsista.Replace ("sim", "true");
                validarBolsista = validarBolsista.Replace ("não", "false");

                if (validarBolsista == "true") {
                    aluno.Bolsista = true;
                    System.Console.WriteLine ("\nAluno Bolsista!!");
                } else {
                    aluno.Bolsista = false;
                    System.Console.WriteLine ("\nAluno Não Bolsista");
                }

            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe, Ocorreu um Erro na Aplicação: ");
                SalvarErros (ex);
            }
        }
        public void ImprimeDados () {
            System.Console.WriteLine ("Nome: " + aluno.Nome);
            System.Console.WriteLine ("Curso: " + aluno.Curso);
            System.Console.WriteLine ("Idade: " + aluno.Idade);
            System.Console.WriteLine ("RG: " + aluno.Rg);
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