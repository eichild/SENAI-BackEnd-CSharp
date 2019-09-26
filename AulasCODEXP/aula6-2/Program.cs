using System;

namespace aula6_2 {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Digite seu CPF :");
            string cpf = Console.ReadLine ();

            Console.WriteLine (validaCPF (cpf));

        }
        /// <summary>
        /// Função para validação de CPF
        /// </summary>
        /// <param name="cpfUsuario"></param>
        /// <returns></returns>
       public static bool validaCPF (string cpfUsuario) {
            bool resultado = false;
            int[] vetor = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpfCalculo = "";

            string digitoVerificador1 = "";
            string digitoVerificador2 = "";

            int calculo = 0;
            int resto = 0;
            //Pega partes de uma string
            cpfCalculo = cpfUsuario.Substring (0, 9);

            //Elimina os pontos e traços
            cpfUsuario = cpfUsuario.Replace (" ", "");
            cpfUsuario = cpfUsuario.Replace ("-", "");
            cpfUsuario = cpfUsuario.Replace (".", "");
            cpfUsuario=cpfUsuario.Replace("/", "");
            

            for (int i = 0; i <= 8; i++) {
                //Calculando os numeros do cpf com o vetor criado, convertendo de char para string e de string para inteiro 
                calculo += int.Parse (cpfUsuario[i].ToString ()) * vetor[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digitoVerificador1 = "0";
            } else {
                digitoVerificador1 = calculo.ToString ();
            }

            if (digitoVerificador1 == cpfUsuario[9].ToString ()) {
                resultado = true;
            }
            //SEGUNDO DIGITO VERIFICADOR
            int[] vetor2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;
            cpfCalculo = cpfCalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 9; i++) {
                //Calculando os numeros do cpf com o vetor criado, convertendo de char para string e de string para inteiro 
                calculo += int.Parse (cpfUsuario[i].ToString ()) * vetor2[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digitoVerificador2 = "0";
            } else {
                digitoVerificador2 = calculo.ToString ();
            }

            if (digitoVerificador2 == cpfUsuario[10].ToString ()) {
                resultado = true;
            }else{
                resultado=false;
            }
            return resultado;
        }
    }
}