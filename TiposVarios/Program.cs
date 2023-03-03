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
            float A = 19.11f;
            double AA = 87.45e-79;
            bool B = false;
            bool BB = true;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Variaveis Inteiras");
            Console.WriteLine(ca);
            Console.WriteLine(cs);
            Console.WriteLine(cd);
            Console.WriteLine(cf);
            Console.WriteLine("Reais");
            Console.WriteLine(A);
            Console.WriteLine(AA);
            Console.WriteLine("Booleans");
            Console.WriteLine(B);
            Console.WriteLine(BB);
        }
    }
}
