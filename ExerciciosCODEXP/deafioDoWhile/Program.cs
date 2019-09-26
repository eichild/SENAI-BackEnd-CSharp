using System;

namespace deafioDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int acumulador=0;
            int i=1;

            do{
                Console.Write("Digite numeros: ");
                num=int.Parse(Console.ReadLine());
                i++;
                if(num % 2 !=0){
                  acumulador+=num;
                }
            }while(i<=20);
             Console.Write(acumulador);
            
        }
    }
}
