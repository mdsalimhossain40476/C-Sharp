using System;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  C# Strings
            /*
                String টেক্সট সঞ্চয় / স্টোর করার জন্য ব্যবহৃত হয়।

                একটি String ভেরিয়েবলের মধ্যে ডাবল "o" কোটেশন দ্বারা ঘেরা অক্ষরের একটি সংগ্রহ থাকে।

                String টাইপের একটি ভেরিয়েবল তৈরি করুন এবং এটিকে একটি মান বরাদ্দ করুন:

            */
            string greeting = "Hello";
            string greeting2 = "Nice to meet you";
            Console.WriteLine(greeting);    //  Outputs	:	Hello    
            Console.WriteLine(greeting2);   //  Outputs	:	Nice to meet you

            //  একটি স্ট্রিং ভেরিয়েবল অনেক গুলো শব্দ ধারণ করতে পারে, যদি আপনি চান:
            /*
              String Length
              C# তে একটি স্ট্রিং আসলে একটি অবজেক্ট, যার মধ্যে স্ট্রিং-এ নির্দিষ্ট অপারেশন কার্যকর করার জন্য 
              প্রোপার্টি এবং পদ্ধতি রয়েছে। উদাহরণস্বরূপ, একটি স্ট্রিংয়ের দৈর্ঘ্য Length প্রোপার্টি দিয়ে পাওয়া যায়।
            */
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length); //  Outputs: The length of the txt string is: 26


            /*
                Other Methods
                অনেক স্ট্রিং পদ্ধতি পাওয়া যায়, যেমন ToUpper() এবং ToLower(), 
                যা স্ট্রিংয়ের একটি কপি ফেরত দেয় যা বড় হাতের অক্ষর অথবা ছোট হাতের অক্ষরে রূপান্তরিত হয়েছে:

             */
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());    // Outputs :    HELLO WORLD
            Console.WriteLine(txt1.ToLower());    // Outputs :    hello world
            Console.ReadLine ();
        }
    }
}
