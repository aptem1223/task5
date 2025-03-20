using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Abstract
    {
        public void Method1()=>
            Console.WriteLine("ОБЫЧНЫЙ МЕТОД METHOD 1 ИЗ Абстрактный класса Abstract ");
        public void Method2() =>
            Console.WriteLine("ВУРТУАЛЬНЫЙ МЕТОД METHOD 2 ИЗ Абстрактный класса Abstract ");
        public abstract void Method3();
        public abstract void Method4();

    }
}
