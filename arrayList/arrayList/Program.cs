using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            ArrayList a1 = new ArrayList();
            int[] a2 = new int[5];
            a1.Add(5);
            a1.Add(10);
            a1.Add(15);
            a1.Add(20);
            a1.Add(25);
            a1.Add(5);
            a1.Add(10);
            a1.Add(15);
            a1.Add(20);
            a1.Add(25);

            bool y = a1.Contains(15);

            a1.CopyTo(0, a2, 0, 4);

            a1.Insert(3, 30);

            int c = a1.Capacity;

            for (int i = 0; i < a1.Count; i++)
            {
                System.Console.WriteLine(a1[i]);
            }
            System.Console.WriteLine();

            System.Console.WriteLine(y);
            System.Console.WriteLine();


            for (int i = 0; i < a2.Length; i++)
            {
                System.Console.WriteLine(a2[i]);
            }
            System.Console.WriteLine();


            for (int i = 0; i < a1.Count; i++)
            {
                System.Console.WriteLine(a1[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine(c);




            System.Console.ReadKey();
        }
    }
