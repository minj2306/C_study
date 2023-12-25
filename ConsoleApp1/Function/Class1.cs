using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Function
{
    internal class Class1
    {
        public int addNumber(int a, int b) { 
            int c = a + b;
            return c;
        }

        public void soundFunction() {
            Console.WriteLine("소리를 냅니다.");
        }

        public void readNumber(int a) {
            Console.WriteLine("숫자를 출력합니다 : " + a);
        }

    }
}
