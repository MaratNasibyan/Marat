using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    delegate V MyDel<U, V>(U argument);

    class Program
            {
            class building<T> where T:class
            {
                T obj;
                public building(T t)
                {
                    obj = t;
                }
            }
            static void Main(string[] args)
            {
                Random r = new Random();
                building<Random> d = new building<Random>(r);
                Home home = new Home();
                home[1] = 5;
                Console.Write(home[0].ToString());

                MyDel<int, int> del1 = new MyDel<int, int>(Method1);

                Console.WriteLine("____________________________________________________");

                Generics<int, string> generics = new Generics<int, string>(5, "dsf");
                generics.getType();

                Console.ReadKey();
            }
        class Home
        {
            int[] arr = { 5,6};

            public int this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }
        class MyClass<T>
        {
            public T field;

            public void GetPrintType()
            {
                Console.WriteLine(field.GetType());
            }
           
        }
        public  static int Method1(int i)
        {
            return i;
        }
        static class A
        {
            public static void Method<T>(T argumnet)
            {
                T v = argumnet;
                Console.WriteLine(v);
            }
            
                    
        }
        class Generics<U,V>
        {
            U u;
            V v;

            public Generics(U u,V v)
            {
                this.u = u;
                this.v = v;
            }

            public void getType()
            {
                Console.WriteLine(u.GetType() + "  " + v.GetType());
            }

        }
    }
}
