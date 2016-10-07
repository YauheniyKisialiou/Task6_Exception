using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class FileReader
    {
        public string GetFilePath()
        {
            Console.WriteLine("Enter path to file");
            string filePath;
            filePath = Console.ReadLine();
            if (filePath.Equals(""))
            {
                throw new NothingEnteredException();
            }
            return filePath;
        }

        public List<string> ReadFile(string filePath)
        {
            List<string> list = new List<string>();

            list = File.ReadAllLines(filePath).ToList();
            if (list.Count == 0)
            {
                throw new FileISEmptyException();
            }
            return list;
        }

        public void Display(List<string> list)
        {
            LogWriter lw = new LogWriter();
            foreach (var item in list)
            {
                try
                {
                    if (item.Equals(""))
                    {
                        throw new EmptyStringException();
                    }
                    else
                    {
                        Console.WriteLine(item.Substring(0,1));
                    }
                }
                catch (EmptyStringException e)
                {
                    Console.WriteLine("Empty string");
                    lw.WriteLog(e.StackTrace);
                }
                
            }
        }
    }

    class EmptyStringException : Exception
    {

    }

    class NothingEnteredException : Exception
    {

    }

    class FileISEmptyException : Exception
    {

    }
}
