using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            for(int i=1;i<=100;i++){
                res=i*i*i;
                Console.WriteLine(i+" Elevado ao cubo: "+res);
            }
        }
    }
}
