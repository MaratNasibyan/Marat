using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //Linq Cast i OfType
            ArrayList array = new ArrayList();
            array.Add("Marat");
            array.Add("Anahit");

            IEnumerable<string> arr1 = array.Cast<string>().Where(n => n.Length > 5);
            IEnumerable<string> arr2 = array.OfType<string>().Where(n => n.Length > 5);
            Console.WriteLine("----------------------------");

            int[] arr = new int[] { 5, 10, 8, -9 };

            IEnumerable<int> en = arr.Where(n => n > 8 && n < 10);
            var j = arr.Count();
            //foreach(var v in en1)
            //{
            //    Console.WriteLine(v.ToString());
            //}
            Linq40();
            Console.WriteLine("_____________________________________________________");
            Linq41();
            Console.WriteLine("_____________________________________________________");

            List<Product> data = CreateData();

            var MinCtegoryProducts = from n in data
                                     group n by n.Category into g
                                     select new {Category=g.Key,Price = g.Min(n=>n.Price) };

            foreach (var v in MinCtegoryProducts)
            {
                Console.WriteLine(v.Category + "  " + v.Price);
            }

            Console.WriteLine("________________________________");

            Linq92();
            Console.WriteLine("________________________________");

            Linq64();
            Console.WriteLine("________________________________");
            List<Product> joindata = CreateData();
            Shop[] arrShop = new Shop[4];
            arrShop[0] = new Shop() { ISN = 1, Name = "ErevanCity" };
            arrShop[1] = new Shop() { ISN = 2, Name = "Sas" };
            arrShop[2] = new Shop() { ISN = 3, Name = "GoodWin" };
            arrShop[3] = new Shop() { ISN = 4, Name = "Star" };


            var query = joindata.Join(arrShop, p => p.ISN, sh => sh.ISN,

                (p, sh) => new {Name = p.Name,Price = p.Price,ShopName=sh.Name });

            foreach(var obj in query)
            {
                Console.WriteLine(obj.Name + "  " + obj.Price.ToString() + " " + obj.ShopName);
            }

            Console.ReadKey();
        }
        class Shop
        {
            public int ISN { get; set; }
            public string Name { get; set; }
        }
        public static void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int fourthLowNum = (
                from n in numbers
                where n > 5
                select n)
                .ElementAt(1);  // second number is index 1 because sequences use 0-based indexing
            
            Console.WriteLine("Second number > 5: {0}", fourthLowNum);
        }
        public static void Linq92()
        {
            double[] doubles = { 5, 5, 5, 5,5};

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }
        public static void Linq40()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new {Remainder = g.Key, y = g };

            foreach (var g in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                foreach (var n in g.y)
                {
                    Console.WriteLine(n);
                }
            }
        }
        public static void Linq41()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var wordGroups =
                from w in words
                group w by w[0] into g
                select new { FirstLetter = g.Key, Words = g };

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
        public class Product
        {
            public int ISN { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Category { get; set; }
        }
        public static List<Product> CreateData()
        {
            List<Product> products = new List<Product>() {
                new Product() {ISN=1,Name="Sugar",Price=45, Category = "A Group" },
                new Product() {ISN=2,Name="Cofee1",Price=50,Category="B Group" },
                new Product() {ISN=3,Name="Cofee2",Price=70,Category="B Group" },
                new Product() {ISN=4,Name="Sugar",Price=50, Category = "A Group" }
                               
            };
            return products;
        }
    }
}
