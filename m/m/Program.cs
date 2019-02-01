using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
  

    public class program
    {
        public static void Main()
        {
            specialist[] s=new specialist[3];
            s[0] = new specialist("Ruturaj Sawant", "Male", 21, 12345);
            s[1] = new specialist("Ruturaj Sawant1", "Male", 21, 123456);
            s[2] = new specialist("Ruturaj Sawant2", "Male", 21, 1234567);
            
            s[0].display();
            s[1].display();
            s[2].display();

            employee[] e = new employee[3];
            e[0] = new employee("Ruturaj Sawant", "Male", 21, 12345);
            e[1] = new employee("Ruturaj Sawant1", "Male", 21, 123456);
            e[2] = new employee("Ruturaj Sawant2", "Male", 21, 1234567);

            e[0].display();
            e[1].display();
            e[2].display();

            System.Console.ReadKey();
        }

    }
}
