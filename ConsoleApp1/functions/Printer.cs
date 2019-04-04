using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.functions
{
    class Printer
    {
        //Printer Out
        public void PrintOut(out string str)
        {
            str = "Print string with: \'out\'";
        }

        //Printer Ref
        public void PrintRef(ref string str)
        {
            str = "Print string with: \'ref\'";
        }
    }
}
