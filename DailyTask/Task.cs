using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask
{
    public class Task
    {
        int Count;

        public void method()
        {
            Console.WriteLine("Enter the Count");
            Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        public void pattern2()
        {
            Console.WriteLine("Enter the Count");
            Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 5; i >= 1; i--)
            {
                char ch = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }



        }
        public void pattern3()
        {
            Console.WriteLine("Enter the Count");
            Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 5; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void pattern4()
        {
            Console.WriteLine("Enter the Count");
            Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 5; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }

        public void pattern5()
        {
            
            Console.WriteLine("Enter the Count");
            Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Count; i++)
            {
                for (int j = 1; j <= (Count - i); j++)
                {
                    Console.Write(" ");
                }
                  
                for (int t = 1; t < i * 2; t++)
                {
                    Console.Write("*");
                }
                    
                Console.WriteLine();
            }


            Console.WriteLine();
        }

        public void method2()
        {
            int number = 0;
            // Begin do-while loop.
            // ... Terminates when number equals 2.
            do
            {
                Console.WriteLine(number);
                // Add one to number.
                number++;
            } while (number <= 2);

        }

        public void method3()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write("While statement ");
                // Write the index to the screen.
                Console.WriteLine(i);
                // Increment the variable.
                i++;
            }

        }

    }
}

