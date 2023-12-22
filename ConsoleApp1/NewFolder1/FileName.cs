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

            int g = 5;
            g %= 3;
            Console.WriteLine(g);

            int h = 5;
            int i = 6;
            bool result = (h != i);
            Console.WriteLine(result);
            
            string j = ( h > i ) ? "참입니다." : "거짓입니다." ;

            Console.WriteLine(j);

            /*
             ! 논리부정 !ture -> false / !false -> true
             && 둘다 같을때 true
             || 둘중 하나만 같으면 true
             */
            if (!result) {
                Console.WriteLine("zzz");
                    }
            else
            {
                Console.WriteLine("ㅋㅋㅋ");
            }

            bool result2 = true;
            bool result3 = false;

            if (result2 || result3) {
                Console.WriteLine("ㄱㄱㄱ");
            }
            else { Console.WriteLine("rrr"); }

            /*
             비트 연산자
             & : 두 비트중 모두 1일 경우에만 1
             | : 두 비트중 하나만 1이어도 1
             ^ : 두 비트중 하나만 1 이고 다른 하나가 0 일때 계산결과가 1^1 또는 0^0 은 계산결과 0

             비트연산자는 그림에 효과를 주거나 전자 또는 전기시스템의 회로구성이 논리적 and 게이트 등 
             하드웨어적인 요소가 논리연산으로 계산을 하기 떄문에 시스템 프로그램 개발 등 특수한 환경에 주로 사용
             */

            // 비트 연산자는 2진수로 계산
            int k = 1; // 0001
            int l = 5; // 0101
            int m = 0; // 0000

            Console.WriteLine( k & l);
            Console.WriteLine( k | l);
            Console.WriteLine( k ^ l);

        }
    }
}
