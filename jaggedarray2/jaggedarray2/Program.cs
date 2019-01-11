using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            int[,] std = new int[5, 5];

            System.Console.WriteLine("Enter Roll no. and Marks of 3 subject");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    std[i,j]=Convert.ToInt32(System.Console.ReadLine());
                }
            }

            //Toatal marks
            for (int i = 0; i < 5; i++)
            {
                int total = 0;
                for (int j = 1; j < 4; j++)
                {
                   total = total + std[i, j];
                }
                std[i, 4] = total;
                System.Console.Write("Total marks of "+std[i,0]+" :");
                System.Console.WriteLine(total);
            }


            //Hightest in subject

           
            for (int i = 1; i < 4; i++)
            {
                int highest = std[0,i];
                int Rollno = std[0, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (std[j, i] > highest)
                    {
                        
                        highest = std[j,i];
                    }
                    
                }

                System.Console.WriteLine("Highest marks in subject "+i+" is "+highest);
          }


            //Highest scorer
            int high = std[0, 4];
            int roll = std[0, 0];
            for (int i = 1; i < 5; i++)
            {
                if (high < std[i, 4])
                {
                    high = std[i, 4];
                    roll = std[0, i];
                }
            }

            System.Console.WriteLine("Highest marks obtained is "+high+" by Roll no. "+roll);

            System.Console.ReadKey();

        }
    }

