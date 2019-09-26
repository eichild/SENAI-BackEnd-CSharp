using System;

namespace exercicio_1 {
    class Program {
        static void Main (string[] args) {
            //Faça um algoritmo que leia os valores de 10 posições e exiba o vetor e sua última posição multiplicada por 5.
            int[] numeros = new int[10];
            int res;
            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite um numero: ");
                numeros[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                Console.Write (numeros[i] + " - ");
            }

            res = numeros[9] * 5;
            Console.Write ("Ultimo indice  multiplicado por 5: " + res);
        }
    }
}