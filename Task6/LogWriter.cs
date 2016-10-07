using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class LogWriter
    {
        

        public  void WriteLog(string str)
        {
            string logPath = @"d:\log.txt";

            StreamWriter sw = new StreamWriter(logPath, true);

            try
            {
                sw.Write(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sw.Close();
        }

        
    }
}
