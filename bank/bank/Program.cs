using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            savingAcc s = new savingAcc();
            s.setAcc("Ruturaj","123456","Savings",98765);
            s.add(1000);
            s.withdraw(1000);
            System.Console.ReadKey();
        }
    }
}
