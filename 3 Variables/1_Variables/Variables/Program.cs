using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               ভ্যারিয়েবল গুলি হল ডাটা ভ্যালু সংরক্ষণের জন্য কন্টেইনার।
               C# এ, বিভিন্ন প্রকারের ভেরিয়েবল রয়েছে (বিভিন্ন কীওয়ার্ড দ্বারা সংজ্ঞায়িত), 
               যেমন: 
               1.	int - দশমিক ছাড়া পূর্ণ সংখ্যা (যেমন, 123 বা -123) সংরক্ষণ করে।
               2. 	double - দশমিক সহ ফ্লোটিং পয়েন্ট সংখ্যা সংরক্ষণ করে, যেমন 19.99 অথবা -19.99।
               3. 	char - 'a' বা 'B' এর মত একক অক্ষর সংরক্ষণ করে। Char মানগুলো একক ' ' উদ্ধৃতি চিহ্ন দ্বারা বেষ্টিত থাকে।
               4.	 string - টেক্সট স্টোর করে, যেমন "Hello World"। স্ট্রিং "Hello" ভ্যালুগুলো ডাবল কোট দ্বারা বেষ্টিত থাকে।
               5. bool - দুটি অবস্থার মান সংরক্ষণ করে: সত্য বা মিথ্যা।
               
            */
            /*
               Declaring (Creating) Variables
               একটি ভেরিয়েবল তৈরি করতে, আপনাকে অবশ্যই টাইপটি উল্লেখ করতে হবে এবং এটিকে একটি মান নির্ধারণ করতে হবে:
               Syntax :	Type variableName = value;
               
               যেখানে টাইপ হল একটি C# টাইপ (যেমন int বা string), এবং variableName হল ভেরিয়েবলের নাম (যেমন x বা name)। ভেরিয়েবলে মান অ্যাসাইন করার জন্য সমান চিহ্ন ব্যবহার করা হয়।
               
               "John" মানটি নিয়োগ করে স্ট্রিং টাইপের একটি ভেরিয়েবল তৈরি করুন যার নাম name:
               
            */

            string name = "John";
            Console.WriteLine(name);  // Output  :	John
            /*
               একটি ভেরিয়েবল তৈরি করতে হলে, যা একটি সংখ্যা সংরক্ষণ করবে, নিচের উদাহরণটি দেখুন:
               Example
               int টাইপের myNum নামের একটি ভেরিয়েবল তৈরি করুন এবং এটিকে 15 মানটি অ্যাসাইন করুন:
               
            */

            int myNum = 10;
            Console.WriteLine(myNum);  // Output  :	10

            /*
               আপনি মান না দিয়ে একটি ভেরিয়েবল ডিক্লেয়ার করতে পারেন, এবং পরে মান নির্ধারণ করতে পারেন: 
           */
            int myNumner;
            myNumner = 5;
            Console.WriteLine(myNumner);   // Output  :	5

            /*
                মনে রাখবেন যে যদি আপনি কোন বিদ্যমান ভেরিয়েবলকে নতুন মান নির্ধারণ করেন, তাহলে এটি পূর্ববর্তী মানকে ওভাররাইট করবে:
            */

            int myNum1 = 15;
            myNum1 = 20;
            Console.WriteLine(myNum1);  // Output  :	20



            Console.ReadLine();

        }
    }
}
