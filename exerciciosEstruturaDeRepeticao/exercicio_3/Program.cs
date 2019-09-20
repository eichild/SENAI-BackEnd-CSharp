using System;

namespace exercicio_3 {
    class Program {
        static void Main (string[] args) {
            //Escreva um algoritmo que leia um número n e imprima todos os múltiplos de 5, no intervalo de 1 a n.
            int num;
    
            Console.Write ("Digite um numero para mostrar seu multiplos de 5: ");
            num = int.Parse (Console.ReadLine ());
                for(int i=1;i<=num;i++){
                    if(i % 5 ==0){
                    Console.WriteLine(i);
                }
            }

        }
        }
    }
