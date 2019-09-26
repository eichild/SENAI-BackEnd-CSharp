using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int contador=0;

            for(int i=1; i<=10;i++){
                Console.WriteLine("Digite a idade");
                idade=int.Parse(Console.ReadLine());
                //Incremento
                if(idade>=50){
                    //Contador está contando quem tem mais de 50 anos
                    contador+=1;
                }
            }
            Console.WriteLine(contador+" São maiores de 50");

            
        }
    }
}
