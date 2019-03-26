using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fibbonachi
{
    public class Program
    {
        static void Main(string[] args)
        {
            FibbonachiNumbers fibbonachi = new FibbonachiNumbers();
            fibbonachi.FibbonachyInText();

            Console.ReadLine();

            PlusNumbers plus = new PlusNumbers();
            plus.PlusNumbersInTextFile();
        }
    }
}
