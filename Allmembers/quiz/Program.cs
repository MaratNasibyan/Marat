using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        interface IControl
        {
            void Paint();
        }
        interface IForm
        {
            void Paint();
        }
        class Page : IControl, IForm
        {
            public void Paint() { Console.WriteLine("jjjjjjjj"); }
        }

        static void Main(string[] args)
        {
            Page p = new Page();
            p.Paint();

            Console.ReadKey();
        }
    }
}
