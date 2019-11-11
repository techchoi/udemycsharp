using System;

namespace udemyAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia !");
            Console.WriteLine("Boa tarde !");

            //se eu apenas escrever console.write o código não fará a quebra de linha, ficando em uma linha só, um do 
            //lado do outro. MAS só funcina se o write estive antes do segundo Write Line
            Console.Write("Bom dia !");
            Console.WriteLine("Boa tarde !");
        }
    }
}
