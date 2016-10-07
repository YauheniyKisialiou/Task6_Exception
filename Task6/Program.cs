using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter lw = new LogWriter();

            try
            {
                FileReader fr = new FileReader();
                string filePath = fr.GetFilePath();
                fr.Display(fr.ReadFile(filePath));
            }
            catch (NothingEnteredException e)
            {
                Console.WriteLine("Nothing entered");
                lw.WriteLog(e.StackTrace);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
                lw.WriteLog(e.StackTrace);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Empty string");
                lw.WriteLog(e.StackTrace);
            }
            catch (FileISEmptyException e)
            {
                Console.WriteLine("File is empty");
                lw.WriteLog(e.StackTrace);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found");
                lw.WriteLog(e.StackTrace);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                lw.WriteLog(e.StackTrace);
            }

            Console.ReadLine();

        }
    }
}
