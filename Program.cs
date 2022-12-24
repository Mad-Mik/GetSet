using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Classsss1 obj1 = new Classsss1();
            Console.WriteLine(obj1.MyProperty2);

            Classsss1 obj2 = new Classsss1(1, 2, 3);

            //obj2.p_write = 111;
            obj1.p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj1.p);
            Console.ReadKey();

        }
    }
}
