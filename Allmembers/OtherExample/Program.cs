using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherExample
{
    class Program
    {
        internal class A { }
        internal class B :A { }

        static void Main(string[] args)
        {
            object o1 = new object();
            object o2 = o1;
            object o3 = new B();

            LinkedList<int> arr = new LinkedList<int>();
            arr.AddFirst(10);
            arr.AddFirst(30);
            while(arr!=null)
            {
                
            }
            

            Console.ReadKey();
            
           

        }
    }
}
