using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson35
    {
        public string WriteRead()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            objWrite.WriteLine("Hello and Welcome It is the first content of the text file mytest.txt");
            objWrite.Close();
            fs.Close();
            return " ";
        }
        public string Readonly()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string l = " ";
            while ((l = sr.ReadLine()) != null)
            {
                Console.WriteLine(l);
            }

            return " ";

        }
    }
}
