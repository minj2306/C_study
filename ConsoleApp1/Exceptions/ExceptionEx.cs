using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    internal class ExceptionEx
    {
        static void Main(string[] args) {

            try
            {
                string a = "";
                a = Console.ReadLine();

                int[] asd = { 0, 1, 2, 3 };
                Console.WriteLine(asd[Int32.Parse(a)]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally {
                Console.WriteLine("오류가 발생하거나 , 오류가 발생하지 않아도 실행되는 영역");
            }
        
        }

    }
}
