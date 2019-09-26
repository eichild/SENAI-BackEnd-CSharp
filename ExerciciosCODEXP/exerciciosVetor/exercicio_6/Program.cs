using System;

namespace exercicio_6 {
    class Program {
        static void Main (string[] args) {
            //Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro vetor que seja soma dos dois primeiros.
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetorRes = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite o numero do primeiro vetor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite o numero do segundo vetor: ");
                vetor2[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                vetorRes[i] = vetor1[i] + vetor2[i];
                Console.WriteLine (vetorRes[i]);
            }
        }
    }
}