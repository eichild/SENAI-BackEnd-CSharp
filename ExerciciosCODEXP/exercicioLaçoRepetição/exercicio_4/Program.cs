using System;

namespace exercicio_4 {
    class Program {
        static void Main (string[] args) {
            for (int i = 0; i <= 100; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine ("Numeros impares: " + i);
                }
            }
            /* DECREMENTO
             for(int i=100;i>=0;i--){
                if(i%2 !=0){
                    Console.WriteLine("Numeros impares: "+i);
                }
            }*/
        }
    }
}