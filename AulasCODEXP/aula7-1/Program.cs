using System;

namespace aula7_1 {
    class Program {
        static void Main (string[] args) {
            int numero;

            try {
                //Escrevemos um bloco de código
                Console.WriteLine ("Digite um numero: ");
                numero = int.Parse (Console.ReadLine ());
            } catch (Exception e) {
                //Mostramos a exceção da regra 
                //Erro gerado na aplicação
                Console.WriteLine ("OPS :c ENTRADA INVALIDA: ERRO: " + e);
            }

        }
    }
}