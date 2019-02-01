using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    public class animal
    {
        string name;
        int age;

        public void display(string n,int a)
        {
            name = n;
            age = a;

            System.Console.WriteLine("Name : " + n);
            System.Console.WriteLine("Age : " + a);
        }
    }
}
