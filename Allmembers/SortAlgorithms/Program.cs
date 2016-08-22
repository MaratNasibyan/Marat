using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        public static void BubleSort()
        {
            int[] arr = {10000, 10, 50, 60, 100, 1, 80,0,500,-9,65 };
            int tmp;

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1; j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }

        public static void BubleSort2()
        {
            int[] arr = { 10000, 10, 50, 60, 100, 1, 80, 0, 500, -9, 65 };
            int tmp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        tmp = arr[i+1];
                        arr[i+1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }

        static void quickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }


        static void Main(string[] args)
        { 
            BubleSort();
            Console.WriteLine("________________________________________");
            //int[] barr = { 500, -9 };
            //quickSort(barr, 0, 2);
            Console.ReadKey();
        }
    }
}
