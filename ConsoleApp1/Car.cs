using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private string model = "PMODEL";
        public string handle = "ABCMODEL";
        protected string a = "ABC";

        public string getModel() {
            return model;
        }
        public void setModel(string str) { 
            model = str;
        }

        public void getModel2()
        {
            Console.WriteLine(handle);
        }
    }
}
