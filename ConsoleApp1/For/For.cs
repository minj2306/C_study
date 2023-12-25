using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.For
{
    internal class For
    {
        static void Main(string[] args) { 
            
            int i = 0;

            while (i < 6) { // i 가 6 미만일때만 반복해서 while 문 안의 코드 실행

                Console.WriteLine("i의 값은 ? " + i );

                i++;

            }

            do
            {
                Console.WriteLine("do 실행");
            }
            while (i < 6);

            for (int u = 0; u < 10; u++) {
                i++;
            }

            Console.WriteLine(i);

            string[] strs = { "바나나" , "사과" , "파인애플" , "망고" };

            foreach(string str in strs) {
                Console.WriteLine(str);
            }

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 6; b++){
                    Console.WriteLine(a + "," + b);    
                }
            
            }

            int[][] numbers = new int[3][];
            numbers[0] = new int[4]{ 1 , 2 , 3 , 4 };
            numbers[1] = new int[3] { 5 , 6 , 7 };
            numbers[2] = new int[2] { 7 , 8 };

            for (int c = 0; c < numbers.Length; c++)
            {
                for (int d = 0; d < numbers[c].Length; d++)
                {
                    Console.WriteLine(c + "," + d + "번째 int : " + numbers[c][d]);

                }
            }
        }

    }
}
