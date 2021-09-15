using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson31
    {
        public string CreateFile()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            objWrite.WriteLine("mytxt file is created");
            objWrite.Close();
            fs.Close();
            return " ";
        }
    }
}
