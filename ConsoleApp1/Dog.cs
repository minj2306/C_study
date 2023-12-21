using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animal
    {
        // 오버라이딩 --> 자식클래스에서 메소드를 재정의
        public override void animalSound() {
            Console.WriteLine("멍멍");
        }
        
    }
}
