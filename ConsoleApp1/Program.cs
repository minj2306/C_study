using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarRenew carRenew = new CarRenew();
            carRenew.handle = "ABC";

            carRenew.getA();

            Animal animal = new Animal();
            animal.animalSound();
            
            Dog dog = new Dog();
            dog.animalSound();

            Owl owl = new Owl();
            owl.animalSound();

            Ga ga = new Ga();
            ga.animalSound();
        }
    }
}
