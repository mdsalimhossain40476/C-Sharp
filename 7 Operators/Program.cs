using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  C# Operators
            //ভেরিয়েবল / পরিবর্তনশীল এবং মানের উপর অপারেশন করার জন্য অপারেটর ব্যবহার করা হয়।

            // নিচের উদাহরণে, আমরা দুটি মানকে একত্রে যোগ করার জন্য +অপারেটর ব্যবহার করি:
            int x = 10 + 5;
            Console.WriteLine(x);  //  Outputs	:	15

            /*
                যদিও + অপারেটর সাধারণত দুটি মান যোগ করতে ব্যবহৃত হয়, যেমন উপরের উদাহরণে, 
                এটি একটি ভেরিয়েবল এবং একটি মান, অথবা একটি ভেরিয়েবল এবং আরেকটি ভেরিয়েবল 
                যোগ করতেও ব্যবহার করা যেতে পারে:
            */
            int sum1 = 10 + 5;              // 15 (10 + 5)
            int sum2 = sum1 + 25;           // 40 (15 + 25)
            int sum3 = sum2 + sum2;         // 80 (40 + 40)

            Console.WriteLine(sum1);        //  Outputs	:	15	
            Console.WriteLine(sum2);        //  Outputs	:	40
            Console.WriteLine(sum3);        //  Outputs	:	80



            Console.ReadLine();
        }
    }
}
