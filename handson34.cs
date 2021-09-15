using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson34
    {
        public string AddText()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\que4.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            objWrite.WriteLine("Hello my name is Sanket");
            Console.WriteLine("a file created with content name que4.txt");
            objWrite.Close();
            fs.Close();
            return " ";
        }
    }
}
