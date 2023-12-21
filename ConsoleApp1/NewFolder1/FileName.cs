using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class FileName
    {

        static void Main(string[] arg) {
            // 단항 연산자
            int a = 5;
            a++; // 1 더해줌
            Console.WriteLine(a);
            
            // 이항연산자
            int b = 3;
            int c = 0;

            //c = a - b;
            c = a + b;
            Console.WriteLine(c);

            // 삼항연산자
            int d = (5 < 3) ? 2 : 0;
            Console.WriteLine(d);

            int f = 5;
            int e = 6;
            Console.WriteLine(e);

            Console.WriteLine(e*f);
            
            Console.WriteLine(e/f);

            Console.WriteLine(f%e);

        }
    }
}
