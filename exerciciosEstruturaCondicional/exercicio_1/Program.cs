using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float despesa;
            bool saldo;
            string retorno;

            Console.Write("Digite seu salario: R$");
            salario=float.Parse(Console.ReadLine());

            Console.Write("Digite suas despesas totais: R$");
            despesa=float.Parse(Console.ReadLine());

            if(salario>despesa){
                saldo = true;
                retorno = "Você está com saldo positivo";
            }else{
                retorno = "Você está com saldo negativo";
            }
            Console.Write(retorno);
        }
    }
}
