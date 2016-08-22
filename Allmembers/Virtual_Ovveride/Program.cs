using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;
namespace Virtual_Ovveride
{
    class Program
    {
        class A
        {
            public virtual void F()
            {
                Console.WriteLine("Virtual A");
            }
        }
        class B : A
        {
            public override void F()
            {
                Console.WriteLine("Override B");

            }
        }

        class C:B
        {
            public override void F()
            {
                Console.WriteLine("Override c");

            }
        }

        interface IA
        {
            void Print();
        }

        interface IB
        {
            void Print();
        }

        public class M:Class1
        {
            protected override void Make()
            {

            }
        }
        static void Main(string[] args)
        {
            C c = new C();
            c.F();
            Book deytel = new Book("a", "b", 2008);

            K k = new K();

            Console.ReadKey();
        }


        class K
        {
            public K()
            {
                Console.WriteLine("Public");
            }

            static K()
            {
                Console.WriteLine("static");

            }
           
        }

        struct Book
        {
            public string name;
            public string author;
            public int year;

            // конструкор
            public Book(string n, string a, int y)
            {
                name = n;
                author = a;
                year = y;
            }
            public void Info()
            {
                Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
            }

            public IEnumerator<int> GetEnumerator()
            {
                throw new NotImplementedException();
            }

          
        }
    }
}
