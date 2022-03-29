using System;
using System.Collections.Generic;
using System.Text;

namespace task_Interface_Upcasting_method
{
    internal class PDF : MainPrintFile
    {
        public override void Print()
        {
            Console.WriteLine("Pdf cap edildi");
        }
    }
}
