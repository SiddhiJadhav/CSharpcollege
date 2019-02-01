using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class savingAcc:account
    {
        public double bal;

        public void setAcc(string name,string no,string type,double bal)
        {
            set(name,no,type);
            this.bal = bal;
            display();
        }

        public void add(double bal1)
        {
            bal = bal + bal1;
                display();
        }

        public void withdraw(double bal1)
        {

            bal = bal - bal1;
            display();
        }

        public void display()
        {
            System.Console.WriteLine("Balance : "+bal);
        }
    }
}
