using System;

namespace Laços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem com laço for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contagem com laço while");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("Contagem com laço do while");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5);

            Console.WriteLine("Contagem com laço foreach");
            int[] obj = { 0, 1, 2, 3, 4 };
            foreach(int prop in obj)
            {
                Console.WriteLine(prop);
            }
        }
    }
}
