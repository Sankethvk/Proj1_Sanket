using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson33
    {
        public string question3()
        {
            string file = @"C:\Training\EuroTraining\Files\mytest.txt";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            else
            {
                FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter objWrite = new StreamWriter(fs);
                objWrite.WriteLine("file was created");

                Console.WriteLine("a file was created with name mytest.txt");
                objWrite.Close();
                fs.Close();

            }
            
            return " ";
        }
    }
}
