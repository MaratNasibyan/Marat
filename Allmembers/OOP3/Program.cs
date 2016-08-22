using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        class A
        {
            //public  void m1() { Console.WriteLine("A"); }
        }
        class B : A 
        {
          //  public  void m2() { Console.WriteLine("B"); }
        }
        class C : B
        {
            public void m3()
            {
                /* програмный код */
                Console.WriteLine("C");
            }
        }
        //-------------------------------------------------------------

            interface Iinter
        {
            void f();
            void o();
                 
        }
        public class Class1
        {
            public void f() { }
            public void o() { }
        }

        public class Class2:Class1,Iinter
        {
            new  public virtual void f() { }
        }


        interface Icontrol
        {
            void paint();
        }

        interface Iform
        {
            void paint();
        }

        class P:Icontrol,Iform
        {
            public void paint() { Console.WriteLine("class P"); }
        }
 

        static void Main(string[] args)
        {

            A a = new A();
            //  A a1 = new B();
            B k = new B();

            A a1 = k;

           
           

            Console.WriteLine(a1.GetType());


            Console.ReadKey();
        }

        struct H
        {

        }
        enum T
        {
            a,
            b,
            c
        }
       
    }
}
