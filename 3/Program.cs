using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            int symbol;
            char result;


            Console.WriteLine("Please, enter your symbol: ");
            do
            {
                
                symbol = Console.Read();
                //if (symbol < 65 && symbol > 90 || symbol < 97 && symbol > 122)
                //{
                //    Console.WriteLine("Please, enter corect form!!!");
                //}
                //if(symbol < 65)
                //{
                //    Console.WriteLine("Please, enter corect form!!!");
                //}
                //else if(symbol > 90 && symbol < 97)
                //{
                //    Console.WriteLine("Please, enter corect form!!!");
                //}
                //else if(symbol > 122)
                //{
                //    Console.WriteLine("Please, enter corect form!!!");
                //}
                if (symbol < 97 && symbol > 122)
                {
                    Console.WriteLine("Erore!!!");
                }
                else if (symbol < 65 && symbol > 90)
                {
                    Console.WriteLine("Erore!!!");
                }
                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                    result = (char)symbol;
                    Console.WriteLine(result);

                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                    result = (char)symbol;
                    Console.WriteLine(result);
                }

                //else
                //{
                //    Console.WriteLine("Please, enter corect form!!!");
                //}


            } while (true);





            //symbol = Console.Read();

            //str = Console.ReadLine();
            //char[] num = str.ToCharArray();
            //for (int i = 0; i < num.Length ; i++)
            //{
            //    symbol = int.Parse(num[i]);
            //}




            Console.Read();
        }
    }
}
