using System;

namespace udemyprogramacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte tem sinal valor maximo 127
            sbyte x = 100;

            Console.WriteLine(x);
            //byte ex de numero que nao tem sinal e vai de 0 a 255
            byte n1 = 254;
            int n3 = 1000;
            int n4 = 1147483647;
            long n5 = 2147483648L;
            //ele soma o valor do n1 + 1 (++)
            n1++;
            Console.WriteLine(n1);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            //se eu fizer sbyte 127 ++ ele se torna -128 pq nao suporta + q 127

            sbyte n2 = 127;
            n2++;


            Console.WriteLine(n2);


            


        }
    }
}
