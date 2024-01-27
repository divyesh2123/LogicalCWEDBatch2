using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter marks for subj1");

            int marks1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter marks for subj2");

            int marks2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter marks for subj3");

            int marks3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter marks for subj4");

            int marks4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter marks for subj5");

            int marks5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter marks for subj6");

            int marks6 = Convert.ToInt32(Console.ReadLine());

            int total = marks1+ marks2 + marks3 + marks4 + marks5 + marks6;

            float per = total / 6;

            if(per <40)
            {
                Console.WriteLine("failed");
            }
            else if(per >=40 && per < 50)
            {
                Console.WriteLine("D");
            }

            else if (per >= 50 && per < 60)
            {
                Console.WriteLine("C");
            }
            else if(per >=60 && per<70)
            {
                Console.WriteLine("B");
            }
            else if(per>=70 && per<80)
            {
                Console.WriteLine("A");

            }
            else
            {
                Console.WriteLine("A++");

            }

            Console.ReadKey();


        }
    }
}
