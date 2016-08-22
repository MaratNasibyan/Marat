using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Show()
        {
            Console.WriteLine("Show message");
            Thread.Sleep(3000);
            Console.WriteLine("End show");
        }

        static int Sum(int j)
        {
            int sum = 0;
           for(int i=0;i<j;i++)
            {
                sum += i;
            }
            return sum;
        }
        public void TPL()
        {
        
            CancellationTokenSource cts = new CancellationTokenSource();
            Task<int> t = new Task<int>(()=>Sum(10000) , cts.Token);
            t.Start();

            cts.Cancel();
        }

     

        static void Main(string[] args)
        {
            Action del = Show;
            Task t = new Task(del);
            Console.WriteLine("Main method");
            t.Start();
            t.Wait();
            
            Task<int> task = new Task<int>(n => Sum((int)n), 1000000);
            task.Start();
            Console.WriteLine(task.Result.ToString());
            Console.WriteLine("-------------------------------------------------------------");

            Task[] arr = new Task[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Task.Factory.StartNew(() => { Console.WriteLine("hello from lambdas"); });
            }
            Task.WaitAll(arr);
            Console.WriteLine("Hello Maratik");
            Console.WriteLine("--------------------------------------------------------------------");
            
            Task t1 = new Task(()=> { Console.WriteLine("Going task1"); });
            Task t2 = t1.ContinueWith(Display);
            t1.Start();
            t2.Wait();
            Console.WriteLine("------------------Parallel programing------------------------");


            Parallel.Invoke(
                () => Console.WriteLine("hello parallel 1 task"),
                () => Console.WriteLine("hello parallel 2 task"),
                Show
                
                );
         
    
            Console.ReadKey();
            
        }
        static void Display(Task t)
        {
            Console.WriteLine("Id задачи: {0}", Task.CurrentId);
            Console.WriteLine("Id предыдущей задачи: {0}", t.Id);
            Thread.Sleep(3000);
        }
    }
}
