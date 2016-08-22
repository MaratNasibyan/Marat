using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    class Program
    {
        class Person : IComparable
        {
            public string Name { get; set; }

            public int CompareTo(object obj)
            {
                Person p = obj as Person;
                if (p != null)
                    return this.Name.CompareTo(p.Name);
                else
                    throw new Exception("error");
            }
        }

        class MyInt:IEnumerable,IEnumerator
        {
            int[] ints = { 10, 20, 30 };
            int index = -1;

            public object Current
            {
                get
                {
                    return this.ints[index];
                }
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }
          
            public bool MoveNext()
            {
                if (index == ints.Length - 1)
                {
                    Reset();
                    return false;
                }
                else index++;return true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Bagrat" };
            Person p2 = new Person { Name = "Anna" };

            Person[] arr = new Person[] {p1,p2 };
            Array.Sort(arr);

            foreach(var v in arr)
            {
                Console.WriteLine(v.Name);
            }

            MyInt m = new MyInt();
            foreach(var h in m)
            {
                Console.WriteLine(h.ToString());
            }

            var Prop1 = new { Name = "Anyutka", Age = 25 };
            Console.WriteLine(Prop1.Name);


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Marat");
            dic.Add(2, "Anna");
            dic.Add(3, "Anahit");
            foreach(KeyValuePair<int,string> v in dic)
            {
                Console.WriteLine(v);
            }
          
                        
            Console.ReadKey();
        }
    }
}
