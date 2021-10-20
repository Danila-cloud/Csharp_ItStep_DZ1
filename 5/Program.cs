using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string str;
            Console.WriteLine("Hello, please, enter your namber: ");
            str = Console.ReadLine();
            char[] num = str.ToCharArray();
            Array.Reverse(num);
            Console.WriteLine(num);


            Console.Read();
        }
    }
}