using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Derived
    {
        public override void Method2()
        {
            base.Method2;
            Console.WriteLine("МЕТОД Method2 КЛАССА Derived ");
        }
        
    }
}
