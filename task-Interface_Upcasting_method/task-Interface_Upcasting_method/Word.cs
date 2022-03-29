using System;
using System.Collections.Generic;
using System.Text;

namespace task_Interface_Upcasting_method
{
    internal class Word :MainPrintFile
    {
        public override void Print()
        {
            Console.WriteLine("Word cap edildi");    
        }
    }
}
