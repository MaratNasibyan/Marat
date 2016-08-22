using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        public interface I
        {
            void Go();
        }
        public class A : I
        {
            public void Go()
            {
                Console.WriteLine("A.Go()");
            }
        }
        class B : A
        {
           
        }
        class C : B, I
        {
            public new void Go()
            {
                Console.WriteLine("C.Go()");
            }
        }
        class EntryPoint
        {
            static void Main()
            {
                B b1 = new B();
                C c1 = new C();
                B b2 = c1;
                b1.Go();
                c1.Go();
                b2.Go();
                ((I)b2).Go();

                Console.WriteLine(b2.GetType());

                //A a = new A();
                //B b = new B();
                //C c = new C();
                //B b2 = c;
                ////B b1 = (B)a;
                //b.Go();
                //a.Go();
                //c.Go();
                //b2.Go();
                Console.ReadKey();
            }
        }

        //static void Main(string[] args)
        //{
        //}
    }
}
