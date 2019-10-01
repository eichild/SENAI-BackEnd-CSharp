using System;
using exercicio3.Controllers;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController objProdutos = new ProdutosController();

            Console.Clear();
            objProdutos.Reserva();
            objProdutos.MostraProduto();

        }
    }
}
