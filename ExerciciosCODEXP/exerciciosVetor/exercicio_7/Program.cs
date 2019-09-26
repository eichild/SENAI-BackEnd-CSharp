using System;

namespace exercicio_7 {
    class Program {
        static void Main (string[] args) {
            //Faça um algoritmo que leia os valores de um vetor de 10 posições e que apresente o maior valor digitado e em qual posição ele se encontra.
            int[] vetor1 = new int[10];
            int indice = 0;
            int maior = 0;

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Insira um valor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());
                //maior = vetor1[i];
                if (maior < vetor1[i]) {
                    indice = i;
                    maior = vetor1[i];
                }
            }
            Console.WriteLine (maior + " é o maior número, índice =  " + indice);
        }
    }
}