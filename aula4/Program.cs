using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula sobre vetor
            double[] nota= new double[10];

            for(int i=0; i<=9;i++){
                Console.Write("Digite nota: ");
                nota[i]=double.Parse(Console.ReadLine());
            }
            Console.WriteLine(nota[3]+"\n");

            //Conta quantos indicies tem no vetor
            for(int i=0; i<nota.Length ;i++){
                Console.WriteLine("Nota: " +nota[i]);
            }
        }
    }
}
