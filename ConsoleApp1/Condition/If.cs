using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Condition
{
    internal class If
    {
        /*
         조건문이란
         참 or 거짓을 통해 코드르 선택적으로 실행 가능한 조건문
         
         조건문의 종류
            if문 ( if , else , else if ) , swich 문
         */
        static void Main(string[] args) {

            int a = 5;
            int b = 10;

            if (a == b)
            {
                Console.WriteLine("참입니다.");
            }
            else { Console.WriteLine("거짓입니다."); }
            if (a < b)
            {
                Console.WriteLine("참입니다.");
            }
            else { Console.WriteLine("거짓입니다."); }

            if (a == b)
            {
                Console.WriteLine("참입니다.");
            }

            else if(a < b) { Console.WriteLine("else if 입니다."); }

            int score = 20;
            if (score < 10)
            {
                Console.WriteLine("현재 점수는 10점 미만입니다.");
            }
            else { Console.WriteLine("현재 점수는 10점 이상입니다."); }

            String result = (score < 10) ? "현재 점수는 10점 미만입니다." : "현재점수는 10점 이상입니다.";
            Console.WriteLine(result);


        }
    }
}
