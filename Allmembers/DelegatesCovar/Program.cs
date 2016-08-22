using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCovar
{

   

    class Program
    {
      
             
        static void Main(string[] args)
        {
            //Console.WriteLine(B.ISN.ToString());

            dynamic d = "Marat";
            d = 2;
            Console.WriteLine(d);
            B b = new B();
          

      //   MyDel del = new MyDel();

            Console.ReadKey();
        }

       
    }
}
