using System;

namespace exercicio_2 {
    class Program {
        static void Main (string[] args) {
            //Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro vetor de 20 posições que seja a união dos dois primeiros.
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];

            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite o valor do primeiro vetor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite o valor do segundo vetor: ");
                vetor2[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                vetor3[i] = vetor1[i];
                vetor3[i + 10] = vetor2[i];
            }
            for (int i = 0; i <= 19; i++) {
                Console.WriteLine (vetor3[i]);
            }
        }
    }
}