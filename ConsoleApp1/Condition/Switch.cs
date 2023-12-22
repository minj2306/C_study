using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Condition
{
    internal class Switch
    {
    /*
        switch문을 사용 할 때는 비교하려는 값이 같은 타입으로 이루어졌을 경우
        switch(expression) 에서 expression 은 각각의 case 와 값을 비교한다.
        만약 일치하면 해당 case 에 속한 코드를 실행한다.
     */
        static void Main(string[] args) {

            int week = 3;

            switch (week) { 
            
                case 1:
                    Console.WriteLine("월요일");
                    break; // break 를 통해 switch 를 종료
            
                case 2:
                    Console.WriteLine("화요일");
                    break;
                
                case 3:
                    Console.WriteLine("수요일");
                    break;
                
                case 4:
                    Console.WriteLine("목요일");
                    break;

                default:
                    Console.WriteLine("선택되지 않았습니다.");
                    break;
            }
            // break 로 switch 종료하면 여기로 와서 코드 진행
        }
    }
}
