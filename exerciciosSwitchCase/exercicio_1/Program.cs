using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORITMO PARA NUMERO DE PEDIDO
            string pedido;  
            

            Console.Write("digite o numero do pedido: ");
            pedido=Console.ReadLine();

            switch(pedido){
                case "1":
                pedido = "Hamburguer";
                break;

                case "2":
                pedido = "Cheese Salada";
                break;

                case "3":
                pedido = "Cheese Burguer";
                break;

                case "4":
                pedido = "Cheese Bacon";
                break;

                default:
                pedido = "Numero do pedido invalido!!!";
                break;
            }
            Console.Write(pedido);
        }
    }
}
