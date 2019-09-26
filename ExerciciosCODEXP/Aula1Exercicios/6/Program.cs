using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float divida;
            float resultado;

            Console.Write("Digite seu salario: R$");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor da divida que possua: R$");
            divida = float.Parse(Console.ReadLine());

            resultado= salario-divida;
            Console.Write("O valor do seu salario é: R$"+salario+" O valor de sua divida é: R$"+divida+" E após pagamento ira sobrar de seu salario :"+resultado);
            
        }
    }
}
