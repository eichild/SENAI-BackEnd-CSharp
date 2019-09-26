using System;

namespace exercicio_4 {
    class Program {
        static void Main (string[] args) {
            //Dados dois vetores, A e B com 15 palavras, construa um terceiro vetor com os dados dos vetores anteriores
            string[] vetor1 = new string[15];
            string[] vetor2 = new string[15];
            string[] vetor3 = new string[30];

            for (int i = 0; i <= 14; i++) {
                Console.Write ("Digite as palavras que deseja armazenar no primeiro vetor: ");
                vetor1[i] = Console.ReadLine ();
            }
            for (int i = 0; i <= 14; i++) {
                Console.Write ("Digite as palavras que deseja armazenar no segundo vetor: ");
                vetor2[i] = Console.ReadLine ();
            }
            for (int i = 0; i <= 14; i++) {
                vetor3[i] = vetor1[i];
                vetor3[i + 15] = vetor2[i];
            }
            for (int i = 0; i <= 29; i++) {
                Console.WriteLine (vetor3[i]);
            }

        }
    }
}