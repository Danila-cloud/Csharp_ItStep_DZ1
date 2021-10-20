using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Hello, please, enter first namber: ");
            a = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("\n And second: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            } while (a >= b);
            b++;

            for (int i = a; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(a + " ");
                }
                a++;
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
