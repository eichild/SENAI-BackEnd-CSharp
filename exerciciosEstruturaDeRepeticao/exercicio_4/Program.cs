using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int media;
            int acumulador=0;
            int i=1;
            int cont=1;
            
            do{
                Console.Write("Digite numero: ");
                num=int.Parse(Console.ReadLine());
                i++;
                if(num>0){
                  Console.Write(num+"\n");
                }else{
                    //RESOLVER ESTA MERDA
                    acumulador++;
                    cont+=num;
                    media=(cont+cont)/acumulador;
                    
                }
            }while(i<=10);
            Console.Write(cont);
           
        
    }
}
}