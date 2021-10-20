using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, figure, k = 0, firstpass = 0, secondpass = 0;
            Console.WriteLine("HEllo, please give me your numeric:");
            do
            {
                figure = Console.ReadKey().KeyChar;
                num = int.Parse(figure.ToString());
                k++;
                if (k <= 3)
                {
                    firstpass += num;
                }
                else
                {
                    secondpass += num;
                }
            } while (k!=6);
            if(firstpass == secondpass)
            {
                Console.WriteLine(" !" +
                    "\n your ticket is happy!");
            }
            else
            {
                Console.WriteLine(" !" +
                    "\n your ticket is not happy!");
            }


            Console.Read();
        }
    }
}
