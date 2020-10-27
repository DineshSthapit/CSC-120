using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 ^4 = 16
            // 2 ^2 = 4
            // 2 ^0 = 1
            byte x = 0b_1000; 

            int b = x << 5;
            Console.WriteLine($"{Convert.ToString(b, toBase: 2)}");  // output: 1111000100000000

         
        }
    }
}
