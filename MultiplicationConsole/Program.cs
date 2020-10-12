using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiplicationConsole
{
    class Program
    {
        static int i = 1;
        static int n = 2;
        static int [] arr = new int[] {1,9,2,8,3,7,4,6,5 };
        
        public static void Multiplication()
        {
            Thread.Sleep(500);
            if (i==arr.Length)
            {
                return;
            }
            Console.WriteLine(arr[i] + "X" + n + "=" + arr[i] * n);
            i++;
            Multiplication();
        }
        static void Main(string[] args)
        {
            Multiplication();
            Console.ReadKey();
        }
    }
}
