using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Haytararum enq delegatner , delegaty class- e
    delegate void MyDelegate();
    delegate double MyDelegate1(double x);

    class Program
    {

        static void Main(string[] args)
        {
            //Bacum enq delegatey ev poxancum enq vorpes parametr funqcia
            MyDelegate d1 = new MyDelegate(Program.F1);
            MyDelegate d11 = F1;
            d1 += d11;
            var p = new Program();
            MyDelegate d2 = new MyDelegate(p.F2);
            MyDelegate d22 = p.F2;

            //delegatnery unenum en ayspisi operacianer
            MyDelegate d;
            d = d1 + d2 + d22;
            //-= hanvum e verjin delegaty
            d -= d2;

            //sa handisanum e ananun method
            MyDelegate d3 = delegate () { };

            //Ananun metodneri tip en
            F(delegate (double x) { return x * x; });
            F(delegate (double x) { return 2 * x; });
            F(Math.Sin);

            //Lambda artahaytutyun e
            F(x => x * x * x);

            //Action ev Funct delgatnery , kariq chika delegat haytararelu , sranq mer xndirnery lucum en
            Action a1 = F1;

            Action<MyDelegate1> a2 = F;

            Action<string, object> a3 = Console.WriteLine;

            Func<double, double> f1 = Math.Sin;
            Func<double, double, double> pow = Math.Pow;

            //lambdaneri greladzevern en , ev nranq ekel en poxel ananun metodnerin
            Action l1 = () => { };
            Action<string> l21 = (string s) => { Console.WriteLine(s.Trim()); };
            Action<string> l22 = (s) => { Console.WriteLine(s.Trim()); };
            Action<string> l23 = s => { Console.WriteLine(s.Trim()); };
            Action<string> l24 = s => Console.WriteLine(s.Trim());

            Func<double> f21 = () => { return -1; };
            Func<double> f22 = () => -1;
            Func<double, double> f23 = x => x * x;

            //Sranq collectioner en , vor ogtagorcvum e Linq-i het ev Enumerable
            var squares = Enumerable.Range(1, 100).Select(n => n * n);
            var sin = Enumerable.Range(0, 100).Select(n => n/100.0).Select(Math.Sin);
            Console.Read();
        }

        //static funqcia e vory stanum e parameter delegate
        static void F(MyDelegate1 d)
        {
            var collection = Enumerable.Range(1, 10);
            foreach (var item in collection)
            {
                Console.WriteLine(d(item));
            }
        }

        //F1 static funqcia
        static void F1()
        {
        }

       //F2 funqcia
        public void F2()
        {

        }
        //F3 funqcia
        public void F3()
        {
            MyDelegate d = F2;
        }
    }
}
