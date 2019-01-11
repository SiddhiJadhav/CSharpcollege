using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];

            System.Console.WriteLine("Enter 2*2 mstrix A: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    a[i, j] = Convert.ToInt32(System.Console.ReadLine());
                }
            }

            System.Console.WriteLine("Enter 2*2 mstrix B: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    b[i, j] = Convert.ToInt32(System.Console.ReadLine());
                }
            }

            System.Console.WriteLine("Addition ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    System.Console.Write(c[i, j] + "\t");
                    
                }
                System.Console.Write("\n");
            }



            System.Console.WriteLine("Subtraction :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                    System.Console.Write(c[i, j] + "\t");

                }
                System.Console.Write("\n");
            }

            System.Console.WriteLine("Multiplication :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int temp = 0;
                    for(int k=0;k<2;k++)
                    {
                        temp = temp + (a[i, k] * b[k, j]);
                    }
                    c[i,j]=temp;
                     System.Console.Write(c[i, j] + "\t");

                }
                System.Console.Write("\n");
            }
           
            

            System.Console.ReadKey();
            
        }
    }

