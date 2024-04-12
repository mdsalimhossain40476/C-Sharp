using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                C# The else Statement
                যদি শর্তটি মিথ্যা হয় তাহলে কোডের একটি ব্লক কার্যকর করতে else স্টেটমেন্ট ব্যবহার করুন।
                if (condition)
                {
                  // যদি শর্তটি সত্য হয় তাহলে কার্যকর করার জন্য কোড ব্লক
                } 
                else 
                {
                  // False হলে চালানোর জন্য কোড ব্লক
                }

            */
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }  //    Outputs:    Good evening.
            /*
                উদাহরণ ব্যাখ্যা করা হল
                উপরের উদাহরণে, time (20) 18 থেকে বেশী, সুতরাং শর্তটি মিথ্যা। এই কারণে, আমরা অন্য শর্তে যাই 
                এবং পর্দায় প্রিন্ট করি "Good evening"। যদি সময় 18 থেকে কম হয়, প্রোগ্রাম প্রিন্ট করবে "Good day"।

             */
            Console.ReadLine();
        }
    }
}
