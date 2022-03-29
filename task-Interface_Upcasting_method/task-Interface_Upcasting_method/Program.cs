using System;

namespace task_Interface_Upcasting_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            PDF pDF = new PDF();
            Excel excel = new Excel();

            MainPrintFile mainPrintFile= word;
            MainPrintFile mainPrintFile1 = excel;
            MainPrintFile mainPrintFile2 = pDF;

            mainPrintFile.Print();
            mainPrintFile1.Print();
            mainPrintFile2.Print();


        }
    }
}
