using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        //Static classi bolor andamnery petq e linen static!
        public static class Calc
        {
            public static int Plus(int x,int y)
            {
                return x + y;
            }

           
        }
        static void Main(string[] args)
        {
            
            Calc.Plus(5,7);
            Console.ReadKey();
        }
        
    }
}
