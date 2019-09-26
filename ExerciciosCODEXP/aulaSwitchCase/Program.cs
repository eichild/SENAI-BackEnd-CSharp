using System;

namespace aula_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            String resultado;
            string final;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine(); 
            
            //Contam a quantidade de caracteres de um elemento
            int caracteres = placa.Length;

            //Pegamos o ultimo digito com o metódo subString
            final = placa.Substring(caracteres - 1);  

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - Seu rodizio é na Segunda-Feira";

            }else if(final == "3" || final == "4"){
                resultado = "IF/ELSE - Seu rodizio é na Terça-Feira";

            }else if(final == "5" || final == "6"){
                resultado = "IF/ELSE - Seu rodizio é na Quarta-Feira";

            }else if(final == "7" || final == "8"){
                resultado = "IF/ELSE - Seu rodizio é na Quinta-Feira";

            }else if(final == "9" || final == "0"){
                resultado = "IF/ELSE - Seu rodizio é na Sexta-Feira";
            }else{
                resultado = "Placa inválida!";
            }
            
            Console.Write(resultado);

            //Estrutura switch
            switch(final){
                case "1":
                resultado = " Switch - Segunda-Feira";
                break;

                case "2":
                resultado = " Switch - Segunda-Feira"; v
                break;

                case "3":
                resultado = " Switch - Terça-Feira";
                break;

                case "4":
                resultado = " Switch - Terça-Feira";
                break;

                case "5":
                resultado = " Switch - Quarta-Feira";
                break;

                case "6":
                resultado = " Switch - Quarta-Feira";
                break;

                case "7":
                resultado = " Switch - Quinta-Feira";
                break;

                case "8":
                resultado = " Switch - Quinta-Feira";
                break;

                case "9":
                resultado = " Switch - Sexta-Feira";
                break;

                case "0":
                resultado = " Switch - Sexta-Feira";
                break;

                default: 
                resultado = " Switch - Placa Inválida";
                break;
            }
            Console.WriteLine(resultado);
    }
}
}