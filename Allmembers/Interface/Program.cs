using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        class Person:ICloneable,IComparable
        {
            public string Name { get; set; }

            public object Clone()
            {
                //return new Person { Name = this.Name };
                return MemberwiseClone();
            }

            public int CompareTo(object obj)
            {
                Person p = obj as Person;
                if(p != null)
                {
                    return this.Name.CompareTo(p.Name);
                }
                throw new Exception("Error");
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Marat" };
            Person p2 = p1.Clone() as Person;
            
            p2.Name = "Anahit";
            Console.WriteLine(p1.Name + "  " + p2.Name);


            Person o1 = new Person { Name = "Alla" };
            Person o2 = new Person { Name = "Anyutka" };
            Person o3 = new Person { Name = "A" };
            // Person o4 = new Person { Name = "ABBNNJJM" };
            Person o4 = new Person { Name = "asadsadAada" };




            Person[] arr = new Person[] { o4, o3, o1,o2};
            Array.Sort(arr);

            foreach(var v in arr)
            {
                Console.WriteLine(v.Name);
            }
            Console.ReadKey();
        }
    }
}
