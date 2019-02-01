using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class account
    {
        public string name, no, type;

        public void set(string name,string no,string type)
        {
            this.name = name;
            this.no = no;
            this.type = type;
        }
    }
}
