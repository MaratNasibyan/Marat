using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    class Program
    {
        static void MyMethods<T>( T a,T b)
        {
            T v1 = a;
            T v2 = b;
            Console.WriteLine(a + "  " + b);
        }

        class MyClass<T> where T:struct
        {
            T t;
            public MyClass(T t) { this.t = t; }
        }
        static void Main(string[] args)
        {
            MyMethods("sada", "sad");
            MyClass<int> i = new MyClass<int>(50);
        
            
            Console.ReadKey();
        }
               
    }
}
