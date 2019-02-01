using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    public class employee : person
    {
        public int code;
        public employee(string n, string g, int a, int code)
            : base(n, g, a)
        {
            this.code = code;
        }
        public void display()
        {
            System.Console.WriteLine("Name : " + name);
            System.Console.WriteLine("age : " + age);
            System.Console.WriteLine("gender : " + gender);
            System.Console.WriteLine("code : " + code);
        }

    }
}
