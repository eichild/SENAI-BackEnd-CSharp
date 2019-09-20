using System;

namespace exercicio_4 {
    class Program {
        static void Main (string[] args) {
            //Dado um conjunto de 20 valores, faça um algoritmo que:
            //a) Imprima os valores que não são negativos.
            //b) Calcule e imprima a média dos valores negativos; 0.
            int num;
            int media = 0;
            int acumulador = 0;
            int contadorNegativo = 0;
            int i = 1;

            do {
                Console.Write ("Digite numero: ");
                num = int.Parse (Console.ReadLine ());
                i++;
                if (num > 0) {
                    Console.WriteLine (num);
                } else if (num < 0) {
                    acumulador += num;
                    contadorNegativo++;
                    media = acumulador / contadorNegativo;
                }
            } while (i <= 10);
            Console.WriteLine (media);

        }
    }

}