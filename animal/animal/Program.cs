using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
   public class Program
    {
        static void Main(string[] args)
        {
            cat c = new cat("jarvis", 10);
            dog d = new dog("batMobile", 10);

            System.Console.ReadKey();
        }
    }
}
