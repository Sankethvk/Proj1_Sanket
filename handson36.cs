using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson36
    {
        public string Specificline()
        {
        
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            string fileName = @"mytest.txt";
            Console.WriteLine("input number of lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            string[] sentences;
            sentences = new string[lines];
            Console.WriteLine("input {0} strings below", lines);
            for(int i=1;i<lines+1;i++)
            {
                Console.Write(" Input line {0} : ", i);
                sentences[i-1] = Console.ReadLine();
            }
            File.WriteAllLines(fileName, sentences);
            Console.Write("\n Input which line you want to display  :");
            int linenumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The content of the line {0} of the file : \n",linenumber);
            string[] liness = File.ReadAllLines(fileName);
            Console.WriteLine(" {0}", liness[linenumber - 1]);
            return " ";





        }
    }
}
