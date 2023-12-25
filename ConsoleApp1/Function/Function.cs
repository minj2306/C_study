using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Function
{
    internal class Function
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            //int c = a + b;
            //int c = addNumber(a, b); 

            Class1 c1 = new Class1();

            int c = c1.addNumber(a , b);

            Console.WriteLine(c);

            c1.soundFunction();
            c1.readNumber(a);
        }

        static int addNumber(int c, int d) {
            int a = c + d;

            return a;
        }
    }
}
