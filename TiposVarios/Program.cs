using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string ca = "\u00A9’";
            string cs = "\u00A9";
            string cd = "\u00A7";
            string cf = "\u00A6";
            Console.WriteLine("Variaveis Inteiras");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ca);
            Console.WriteLine(cs);
            Console.WriteLine(cd);
            Console.WriteLine(cf);
        }
    }
}
