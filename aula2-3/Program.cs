using System;

namespace aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrada = false; //Definindo para não utilizar o else no if
            int idade;
            string retorno;
            
            Console.Write("Digite sua idade: ");
            idade=int.Parse((Console.ReadLine()));

            if(idade>=18){
                entrada = true;
                 retorno = "Entrada Permitida!!!";
            }
            //Não precisa desse if
            if(entrada == true){
                retorno = "Entrada Permitida!!!";
            }
            else{
                retorno = "Entrada não permitida :c";
            }
            Console.Write(retorno);
        }
    }
}
