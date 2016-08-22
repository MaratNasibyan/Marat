using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        public static IEnumerable<int>  arr()
        {
            yield return 1;
            yield return 5;
            yield return 23;

        }
        static void Main(string[] args)
        {
            arr();
            Console.ReadKey();
        }
    }
}
