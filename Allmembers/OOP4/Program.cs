using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Program
    {
        public  class A { }
        public  class B :A { }
        public class C { }
        public static A PrintA()
        {
            return new A();
        }

        public B PrintB()
        {
            return new B();
        }

        static void Main(string[] args)
        {
            //Func<A> funct = ()=> new A();
            //funct = () => new B();

            //Action<B> action = (s) => new A();

            A a = new A();
            B b = new B();

            A a1 = new B();
            B b1 = a as B;

            if(a1 is A)
            {
                Console.WriteLine("a is A");
            }


            Console.ReadKey();
        }
    }
}
