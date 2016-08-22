using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBExtenshion;


namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////List
            List<string> strings = new List<string>();
            strings.Add("Marat");
            strings.Add("Anahit");
            strings.AddRange(new string[] { "wefew", "sdfs" });
            IEnumerable arr = new List<string>();
            strings.Sort();
            
            foreach(var v in strings)
            {
                Console.WriteLine(v);
            }

            ////////////////////////Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>() { { 2,"asd"} };
            dic.Add(1, "Marat");
        //    dic.Add(2, "Anahit");

            foreach(KeyValuePair<int,string> v in dic)
            {
                Console.WriteLine(v);
            }
          
            
            string s = "Marat";

            int count = s.WordCount();

            Dictionary<string, string> fff = new Dictionary<string, string>();
            fff["a"] = "Marat";

            Console.WriteLine(count.ToString());
            Console.ReadKey();
        }
    }
    
}
