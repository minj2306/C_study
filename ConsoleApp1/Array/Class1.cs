using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Class1
    {
    /*
     배열이란 

     동일한 타입의 값이 많을때 변수를 선언 하는 것 대신에 
     많은 변수를 하나의 변수에 저장하고 사용 가능하게 해준다.

     */
        static void Main(string[] args) {

            int[] a = { 1, 2, 3 , 4 };
            string[] vars = { "파인애플" , "사과" , "바나나" };

            Console.WriteLine(vars[2]);
            Console.WriteLine(vars.Length);
            Console.WriteLine(vars[vars.Length - 1]);

            // 2차원 배열 (1 차원 배열을 여러개 가질 수 있다.) -> 3차원 배열은 2차원 배열 여러개
            int[,] abc = { { 1, 2, 3 } ,{ 4 , 5, 6 } , { 7 , 8, 9 } };
            Console.WriteLine(abc[0 , 0]);// 0번쨰 인덱스 배열의 0 번쨰 인덱스의 값
            Console.WriteLine(abc[1 , 2]);// 1번째 인덱스 배열의 2번쨰 인덱스의 값

            // 가변배열
            // 일반 배열은 2차원 배열에서 1차원 배열들의 길이가 모두 같아야함
            // 가변배열은 각각 배열들의 길이 조절 가능 
            
            int[][] ab = new int[3][];// 1차원 배열 몇개 가질 건지 명시해야함
            
            ab[0] = new int[4]; // 0번쨰 배열의 길이는 4
            ab[1] = new int[3]; // 1번쨰 배열의 길이는 3
            ab[2] = new int[5]; // 2번째 배열의 길이는 5

            ab[2][2] = 4;
            ab[2][3] = 5;

            Console.WriteLine(ab[2][3]);
            Console.WriteLine(ab.Length); // 1차원 배열 몇개인지 나옴 -> 3

        }
    }
}
