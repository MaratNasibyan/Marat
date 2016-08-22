using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_
{
    class Program
    {
        class Phone
        {
            public string Name { get; set; }
            public string Company { get; set; }
        }


        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>
            {
                new Phone {Name="Lumia 430", Company="Microsoft" },
                new Phone {Name="Mi 5", Company="Xiaomi" },
                new Phone {Name="LG G 3", Company="LG" },
                new Phone {Name="iPhone 5", Company="Apple" },
                new Phone {Name="Lumia 930", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple" },
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="LG G 4", Company="LG" }
            };

            var phone = phones.GroupBy(n => n.Company);

            foreach(var v in phone)
            {
                Console.WriteLine(v.Key);
                foreach(var t in v)
                {
                    Console.WriteLine(t.Name);
                }
                Console.WriteLine();
            }


            //var phoneGroups = from phone in phones
            //                  group phone by phone.Company;

            //foreach (IGrouping<string, Phone> g in phoneGroups)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach (var t in g)
            //        Console.WriteLine(t.Name);
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
