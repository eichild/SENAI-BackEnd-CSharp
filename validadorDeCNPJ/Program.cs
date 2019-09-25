using System;

namespace validadorDeCNPJ {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Digite seu CNPJ: ");
            string cnpj=Console.ReadLine();

            Console.WriteLine(validaCNPJ(cnpj));

        }
        public static bool validaCNPJ (string cnpjUsuario) {
            bool resultado = false;
            int[] vetor = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cnpjCalculo = "";

            string digitoVerificador1 = "";
            string digitoVerificador2 = "";

            int calculo = 0;
            int resto = 0;
            //Pega partes de uma string
            cnpjCalculo = cnpjUsuario.Substring (0, 12); //12
            
            //Elimina pontos e traços
            cnpjUsuario = cnpjUsuario.Replace (" ", "");
            cnpjUsuario = cnpjUsuario.Replace ("/", "");
            cnpjUsuario = cnpjUsuario.Replace ("-", "");
            cnpjUsuario = cnpjUsuario.Replace (".", "");

            for(int i=0;i<11;i++){
                //Calculando os numeros do cpf com o vetor criado, convertendo de char para string e depois para inteiro
                calculo+= int.Parse(cnpjCalculo[i].ToString())*vetor[i];
            }
            resto=calculo%11;
            calculo=11-resto;

            if(calculo<2){
                digitoVerificador1="0";
            }else{
                //Transformando o calculo do resto em string para ser armazenado no digito verificador
                digitoVerificador1=calculo.ToString();
            }

            if(digitoVerificador1==cnpjUsuario[12].ToString()){
                resultado=true;
            }

              //SEGUNDO DIGITO VERIFICADOR
            int[] vetor2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;
            cnpjCalculo = cnpjCalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 12; i++) {
                //Calculando os numeros do cnpj com o vetor criado, convertendo de char para string e de string para inteiro 
                calculo += int.Parse (cnpjUsuario[i].ToString ()) * vetor2[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 12) {
                digitoVerificador2 = "0";
            } else {
                digitoVerificador2 = calculo.ToString ();
            }

            if (digitoVerificador2 == cnpjUsuario[13].ToString ()) {
                resultado = true;
            }else{
                resultado=false;
            }
            return resultado;
            //Segunto verificador
        }
    }
}