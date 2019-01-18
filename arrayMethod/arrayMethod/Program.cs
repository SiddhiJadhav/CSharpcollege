using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        int[] arr = new int[] { 5, 8, 3, 9, 1 };
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];

        int l = arr.GetLength(0);
        int v = Convert.ToInt32(arr.GetValue(3));
        int l1 = arr.Length;
        //Array.Sort(arr);
        Array.Reverse(arr);
        Array.Copy(arr, arr1, 5);
       // arr.CopyTo(0,arr2,0,3);

      

        System.Console.WriteLine(l+"\n");
        System.Console.WriteLine(v + "\n");
        System.Console.WriteLine(l1 + "\n");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr1[i]);
        }

      
        System.Console.ReadKey();

    }
}