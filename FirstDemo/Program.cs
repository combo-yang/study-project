using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            const int killone = 5;
            const int killtwo = ++killone;
            const int killx = --killone;
                killx += killtwo;
            Console.WriteLine(killone);
            Console.WriteLine(killx);

            Console.ReadKey();








        }
    }
}
