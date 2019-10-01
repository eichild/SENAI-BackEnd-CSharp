using System;
using exercicio2.Controllers;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController objCelular = new CelularController();

            objCelular.InsereDados();
            objCelular.Ligado();
            //objCelular.Desligado();
            objCelular.AcaoCelular();
        }
    }
}
