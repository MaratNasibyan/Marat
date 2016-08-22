using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Program
    {
        interface IA { void Print(); }
        class A : IA
        {
            public A() { Console.WriteLine("Constructor A"); }

            public void Print()
            {
              Console.WriteLine("A Print");
            }
        }

        class B:A
        {
            public B()
            { Console.WriteLine("Construqtor B"); }

            public new void Print()
            {
                Console.WriteLine("B Print");
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            A ab = new B();
            ab.Print();
            Console.WriteLine(ab.GetType());
            Console.ReadKey();
        }
    }
}
