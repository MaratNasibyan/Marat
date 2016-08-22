using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {

     class A:IEnumerable<int>
        {
           

            public IEnumerator<int> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

     struct B
        {

        }

      public  void funct()
        {
            Console.WriteLine("s");
        }
        static void Main(string[] args)
        {
            Parallel.For(0, 1000,(s)=>Console.WriteLine((s).ToString()));
          
            Console.ReadKey();
        }

       
    }
}
