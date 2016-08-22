using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public static class StringExteneshio
    {
        public static int WordCoun(this String s)
        {
            return s.Length;
        }
    }
    class Program
    {
               
        public class Humen:IEnumerable
        { 
            public string Name { get; set; } //Auto Prperties 
           
             int Age;
             public string Surname { get; set; } = "Nasibyan";
             public  int Ageg
                {
                    get
                    {
                        return Age;
                    }
                    set
                    {
                        if (value == 0)
                        {
                            throw new NullReferenceException();
                        }
                        value = Age;
                    }
                }

            private List<string> students = new List<string>();
            public List<string> Students
            {
                get { return students; }
            }

            object d = new object();

            public IEnumerator  GetEnumerator()
            {
                yield return students;
            }
            
        }
        static IEnumerable<int> getCollections()
        {
            yield return 1;
            yield return 5;

        }
        static int M()
        {
            return 1;
        }
        static void Main(string[] args)
        {
            Humen h = new Humen { Name = "Marat", Ageg = 5, Students = { "Marat","Anahit"}  };

            foreach(var v in h.Students)
            {
                Console.WriteLine(v);
            }
           
            foreach (var item in getCollections())
            {
                Console.WriteLine(item.ToString());
            }
            Task<int> t = new Task<int>(()=>M());

           
            Console.ReadLine();
        }
        struct Mara:IEnumerator
        {
            public const int PI = 10; 
            Mara(int a)
            {

            }

            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
