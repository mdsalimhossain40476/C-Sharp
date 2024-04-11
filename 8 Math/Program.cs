
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //      C# Math
            //  C# Math ক্লাসের অনেক গুলি পদ্ধতি আছে যা আপনাকে সংখ্যার উপর গাণিতিক কাজ সম্পাদন করতে দেয়।

            //      Mayh.Max(x,y)
            //      x এবং y এর সবচেয়ে বেশি মানটি খুঁজে বের করতে Math.Max(x, y) পদ্ধতিটি ব্যবহার করা যেতে পারে:
            int x = 5;
            int y = 10;
            Console.WriteLine(Math.Max (5, 10));    // Outputs :      10 

            //      a এবং b এর সবচেয়ে কম মান খুঁজে বের করতে Math.Min(x,y) পদ্ধতি ব্যবহার করা যেতে পারে
            int a = 5;
            int b = 10;
            Console.WriteLine(Math.Min(5, 10));     // Outputs :      5

            //  Math.Sqrt(c) পদ্ধতিটি c এর বর্গমূল ফিরিয়ে দেয়।
            int c = 64;
            Console.WriteLine(Math.Sqrt(c));        // Outputs :      8

            //      Math.Abs(d) মেথডটি d এর নিশ্চিত / পরম (ধনাত্মক) মান ফেরত দেয়।
            double d = -5.78;
            Console.WriteLine(Math.Abs(d));       // Outputs :      5.78

            Console.ReadLine();
        }
    }
}