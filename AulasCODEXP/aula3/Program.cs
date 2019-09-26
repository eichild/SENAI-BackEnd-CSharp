using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nota vai ser acumulador
            double nota=0;
            //contador
            int i=0; 
           
            //LAÇO CONDICIONAL - WHILE
            while(nota != 1000){
               
               Console.Write("Digite a nota de um aluno: ");
               nota += double.Parse(Console.ReadLine());

               if(nota != 1000){
                   nota+=nota;
                   i++;
               }   

            }
        }
    }
}
