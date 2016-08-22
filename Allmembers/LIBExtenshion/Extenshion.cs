using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBExtenshion
{
    public static class Extenshion
    {
        public static int WordCount(this string str)
        {
            return str.Length + 1;
        }
    }
}
