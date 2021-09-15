using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson37
    {
        public string CountLines()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            objWrite.WriteLine(" test line 1");
            objWrite.WriteLine(" test line 2");
            objWrite.WriteLine(" Test line 3");
            objWrite.WriteLine(" test line 4");
            objWrite.WriteLine(" test line 5");
            objWrite.WriteLine(" Test line 6");
            objWrite.Close();
            fs.Close();
            return "";
        }
        public string CountLinesRead()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string l = " ";
            int counter = 0;
            while ((l = sr.ReadLine()) != null)
            {
                counter++;
            }
            Console.WriteLine("The number of lines in the file mytest.txt is {0} ", counter);

            return " ";
        }
    }
}
