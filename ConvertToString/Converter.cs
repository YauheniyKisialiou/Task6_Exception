using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertToInt
{
    public static class Converter
    {
        public static int ConvertToInt(string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (FormatException)
            {
                return 1;
            }
            catch (OverflowException)
            {
                return 2;
            }
        }
    }
}
