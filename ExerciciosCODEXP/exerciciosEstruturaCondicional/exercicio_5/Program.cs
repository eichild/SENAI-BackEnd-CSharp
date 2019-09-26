using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Digite o primeiro numero :");
            num1=int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero :");
            num2=int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero :");
            num3=int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3){
                 Console.Write("Numero maior: "+num1);
            }   
            else if(num2>num3){
                Console.Write("Numero maior: "+num2);
            }else{
            Console.Write("Numero maior: "+num3);
            }
    }
}
}
