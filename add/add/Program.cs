using System;



class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Two No.s : ");

        double d1 = Double.Parse(System.Console.ReadLine());
        double d2 = Double.Parse(System.Console.ReadLine());

        System.Console.Write(d1+"+"+d2+"="+(d1+d2));

        System.Console.ReadKey();


    }
}
