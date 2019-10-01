using System;
using exercicio3.Models;

namespace exercicio3.Controllers {
    public class ProdutosController {
        ProdutosModel produto = new ProdutosModel ();
        string reservado;

        public void Reserva () {
            System.Console.WriteLine ("Digite o nome do produto para cadastrar: ");
            produto.NomeProduto = Console.ReadLine ();

            System.Console.WriteLine ("Deseja Reservar este produto? (Sim/Não)");
            reservado = Console.ReadLine ();
            reservado.ToUpper ();
            reservado = reservado.Replace ("sim", "true");
            reservado = reservado.Replace ("não", "false");

            if (reservado == "true") {
                produto.reserva = true;
            } else {
                produto.reserva = false;
            }
        }
        public void MostraProduto () {
            System.Console.WriteLine ("\nProduto: " + produto.NomeProduto);
            if (produto.reserva == true) {
                System.Console.WriteLine ("Produto Reservado!!!");
            } else {
                System.Console.WriteLine ("Produto não reservado");
            }

        }
    }
}