using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
      
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("Print from virtual Methods");
            }
        }
        class B:A
        {
            private new void Print()
            {
                Console.WriteLine("Print from novirtual methods");
            }
        }

        class C:B
        {
            public void GetSomeMethods()
            {
                Print();
            }
        }

        
            static void Main(string[] args)
            {

                var v = new C();
                v.GetSomeMethods();

            Arr[] f = new Arr[2];
            f[0] = new Arr(5);
            f[1] = new Arr(10);
            Array.Sort(f);

                Console.ReadKey();
            }
        class Arr
        {
            public int id { get; set; }

            public Arr(int i)
            {
                this.id = i;
            }
        }
       
    }
}
