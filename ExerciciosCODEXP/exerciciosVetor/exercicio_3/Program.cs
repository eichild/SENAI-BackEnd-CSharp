using System;

namespace exercicio_3 {
    class Program {
        static void Main (string[] args) {
            /*Um site na web precisa registrar 12 produtos de um fornecedor, crie um vetor para representar estes produtos com os seguintes atributos: Nome do produto, Cor, Tamanho e Preço.*/
            string[] nomeProduto = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];

            for (int i = 0; i <= 12; i++) {
                Console.WriteLine ("---CADASTRO DE PRODUTOS---");
                Console.Write ("Digite o nome do produto: ");
                nomeProduto[i] = Console.ReadLine ();

                Console.Write ("Digite a cor do produto: ");
                cor[i] = Console.ReadLine ();

                Console.Write ("Digite o tamanho do produto(Pequeno,medio,grande): ");
                tamanho[i] = Console.ReadLine ();

                Console.Write ("Digite o preço do produto: ");
                preco[i] = double.Parse (Console.ReadLine ());

                Console.WriteLine ("PRODUTO REGISTRADO COM SUCESSO!!!");
                Console.WriteLine (nomeProduto[i] + " - " + cor[i] + " - " + tamanho[i] + " - " + preco[i] + "\n");
            }
        }
    }
}