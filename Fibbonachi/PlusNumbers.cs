﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fibbonachi
{
    public class PlusNumbers
    {
        public void PlusNumbersInTextFile()
        {
            List<int> strings = new List<int>();
            var loadFile = new StreamReader(@"C:\Users\Acer-PC\source\repos\Fibbonachi\Plus.txt");
            string _string = "";
            while (!loadFile.EndOfStream)
            {
                _string = loadFile.ReadToEnd();
                string[] splitString = _string.Split(' ');
                for (int i = 0; i < splitString.Count(); i++)
                {
                    strings.Add(int.Parse(splitString[i]));
                }
            }
            loadFile.Close();
            var saveFile = new StreamWriter(@"C:\Users\Acer-PC\source\repos\Fibbonachi\PlusResult.txt");
            saveFile.Write(strings.Sum());
            saveFile.Close();
            Console.ReadKey();
        }
    }
}
