using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            
            Console.Write("Digite sua idade: ");
            idade=int.Parse(Console.ReadLine());

            if(idade>0 && idade<10){
                Console.Write("acesso á Everyone (E)");
            }else if(idade>=10 && idade<13){
                Console.Write("Acesso á Everyone 10+");
            }else if(idade>=13 && idade<17){
                Console.Write("Acesso á Teen (T)");
            }else if(idade>=17 && idade<18){
                 Console.Write("Acesso á Mature (M)");
            }else if(idade>=18){
                Console.Write("Acesso á Adults Only (AO)");
            }
        }
    }
}
