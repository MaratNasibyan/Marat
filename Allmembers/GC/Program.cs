using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var v = new Timer((delegate { Console.WriteLine("Hello"); }),"asfa",0,200);
         
        }
    }
}
