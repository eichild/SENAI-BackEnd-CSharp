using System;

namespace exercicio_5 {
    class Program {
        static void Main (string[] args) {
            //Faça um algoritmo que gere um vetor de 10 posições sendo que seu conteúdo seja o dobro de seu próprio índice.
            int[] vetor = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite um numero para ser dobrado: ");
                vetor[i] = int.Parse (Console.ReadLine ());
                vetor[i] += vetor[i];
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine (vetor[i]);
            }

        }
    }
}