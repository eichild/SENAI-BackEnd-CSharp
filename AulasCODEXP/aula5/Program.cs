using System;

namespace aula5 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] dataIda = new DateTime[5];
            DateTime[] dataVolta = new DateTime[5];
            string sair = "";

            while (sair != "0") {
                Console.WriteLine ("\nBem vindo ao nosso sistema de Passagens!\nMenu: ");
                Console.WriteLine ("1- Cadastrar\n2- Listar passagens\n0- Sair");

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                        for (int i = 0; i <= 4; i++) {
                            Console.Write ("Digite nome completo: ");
                            nome[i] = Console.ReadLine ();

                            Console.Write ("Digite a origem: ");
                            origem[i] = Console.ReadLine ();

                            Console.Write ("Digite destino: ");
                            destino[i] = Console.ReadLine ();

                            Console.Write ("Digite a Data Ida: ");
                            dataIda[i] = DateTime.Parse (Console.ReadLine ());

                            Console.Write ("Digite a Data de Volta: ");
                            dataVolta[i] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso!!!");
                        }
                        break;

                    case "2":
                        //validador se estiver vazio os campos
                        for (int i = 0; i <= 4; i++) {
                            if (nome[i] != "" && origem[i] != "" && destino[i] != "" && dataIda[i] != null && dataVolta[i] != null) {
                                Console.WriteLine ("\nPassagem N° " + i + 1);
                                Console.WriteLine (nome[i] + "\n" + origem[i] + "\n" + destino[i] + "\n" + dataIda + "\n" + dataVolta);
                            }

                        }
                        break;

                    case "0":
                        Console.WriteLine ("Obrigado por utilizar nosso sistema! ;)");
                        break;

                    default:
                        Console.WriteLine ("Entrada invalida!!!");
                        break;

                }

            }
        }
    }
}