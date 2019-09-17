using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float pesoNoPlaneta;
            string planeta;

            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("1-MERCURIO 2-VÊNUS  3-MARTE\n4-JÚPITER 5-SATURNO 6-URANO");
            Console.Write("Digite o numero do planeta que deseja: ");
            planeta= Console.ReadLine();

            switch(planeta){
                case "1":
                pesoNoPlaneta = peso * 0.37f;
                Console.Write("Seu peso no planeta MERCÚRIO: "+pesoNoPlaneta);
                break;

                case "2":
                pesoNoPlaneta = peso * 0.88f;
                Console.Write("Seu peso no planeta VÊNUS: "+pesoNoPlaneta);
                break;

                case "3":
                pesoNoPlaneta = peso * 0.38f;
                Console.Write("Seu peso no planeta MARTE: "+pesoNoPlaneta);
                break;

                case "4":
                pesoNoPlaneta = peso * 2.64f;
                Console.Write("Seu peso no planeta JÚPITER: "+pesoNoPlaneta);
                break;

                case "5":
                pesoNoPlaneta = peso * 1.15f;
                Console.Write("Seu peso no planeta SATURNO: "+pesoNoPlaneta);
                break;

                case "6":
                pesoNoPlaneta = peso * 1.17f;
                Console.Write("Seu peso no planeta URANO: "+pesoNoPlaneta);
                break;

                default:
              Console.Write("Planeta invalido!!!");
                break;
            }
            
        }
    }
}
