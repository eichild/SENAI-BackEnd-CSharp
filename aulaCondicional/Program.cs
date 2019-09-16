using System;

namespace aulaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.Write("Digite a primeira nota: ");
            nota1=double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2=double.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            nota3=double.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3)/3;

            //IF ENCADEADO
            if(media>=6){
                Console.WriteLine("Media: "+media+"--> Aprovado");
                //Interpolaçao
                //Console.WriteLine($"Media: {media} Aprovado");
            }
            else if(media<6 && media>=4){
                Console.WriteLine("Media: "+media+"--> Recuperação");
            }
            else{
                Console.WriteLine("Media: "+media+"--> Reprovado");
            }
            }
        }
    }

