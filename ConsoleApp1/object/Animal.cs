using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {

        // virtual : 자식클래스에서 오버라이딩 가능
        public virtual void animalSound() {
            Console.WriteLine("소리를 냅니다.");
        }
    }
}
