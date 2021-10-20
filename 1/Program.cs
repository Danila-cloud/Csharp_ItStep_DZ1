using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            char liter;
            int space = 0;
            string text="";
            Console.WriteLine("Hello, please, enter your text: ");
            do
            {
                liter = Console.ReadKey().KeyChar;
                text += liter;
                if(liter == ' ')
                {
                    space++;
                }
                

            } while (liter != '.');
            Console.WriteLine("\n Your string end. You have (" + space + ") speces. Your string: " + text);
            Console.Read();
        }
    }
}
