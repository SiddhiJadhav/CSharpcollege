using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace dllused
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.display();
            System.Console.ReadKey();
        }
    }
}
