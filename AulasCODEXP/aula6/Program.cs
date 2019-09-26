using System;

namespace aula6 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine (BomDia ());
            ImprimeDataHora ();
            //Chamando função que calcula a media (VETOR)
            Double[] numeros={2,5,2,8,9,5};
            Console.WriteLine(CalculaMedia(numeros));
        
            Console.WriteLine(SomaValores(numeros));
        }

        /// <summary>
        /// função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>retorna Olá! Bom Dia!</returns>
        public static string BomDia () {
            return "Olá, Bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">Sobrecarga  de metodos</param>
        /// <returns>Saudação de acordo com o horário</returns>
        public static string BomDia (string saudacao) {
            int hora = DateTime.Now.Hour;
            if (hora >= 6 && hora <= 12) {
                saudacao = "BOM DIA";
            } else if (hora > 12 && hora <= 18) {

            } else {
                saudacao = "Boa noite";
            }
            return saudacao;
        }
        public static int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Retorna data e hora atuais
        /// </summary>
        public static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }

        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Media</returns>
        public static Double CalculaMedia(double[] valores){
            double resultado=0;
            for(int i=0; i< valores.Length;i++){
                resultado+=valores[i];
            }
            resultado= resultado/valores.Length;
            return resultado;
        }
        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="val">Vetor de doubles</param>
        /// <returns>Soma de valores</returns>
        public static Double SomaValores(double[] valores){
            double resultado=0;
            for(int i=0; i<valores.Length;i++){
                resultado+=valores[i];
            }
            return resultado;
        }
    }
}