using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task obj= new Task();
            //obj.method();
            //obj.pattern2();
            //obj.pattern3();
            //obj.pattern4();
            //obj.pattern5();
            //obj.method2();
            //obj.method3();

            int count;
            Console.WriteLine("Enter a number");
            count=Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= (count - i); j++)
                {
                    Console.Write(" ");
                }

                for (int t = 1; t < i * 2; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
