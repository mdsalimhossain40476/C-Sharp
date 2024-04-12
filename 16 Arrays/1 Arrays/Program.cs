using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Create an Array
                একটি ভেরিয়েবলে একাধিক মান সংরক্ষণ করার জন্যই অ্যারে ব্যবহার করা হয়, প্রতিটি মানের জন্য আলাদা ভেরিয়েবল ডিক্লেয়ার করার পরিবর্তে।
                একটি অ্যারে ঘোষণা করতে, [ ] বর্গাকার বন্ধনীসহ ভেরিয়েবলের প্রকারটি / ধরনটি সংজ্ঞায়িত করুন:

                Syntax
                String [ ] cars;

                এখন আমরা একটি ভেরিয়েবল ডিক্লেয়ার করেছি যা স্ট্রিং এর একটি অ্যারে ধরে রাখে।
                এর মধ্যে মান যুক্ত করতে, আমরা একটি অ্যারে আক্ষরিক - স্থান ব্যবহার করতে পারি - কমা দ্বারা পৃথক করা তালিকায় মানগুলোকে রাখুন, কার্লি ব্রেসের মধ্যে:

                String [ ] cars = {"Volvo", "BMW", "Ford", "Mazda"};

                পূর্ণ সংখ্যার একটি অ্যারে তৈরি করতে, আপনি লিখতে পারেন:

                int[] myNum = {10, 20, 30, 40};

                Access the Elements of an Array
                আপনি সূচক নম্বর উল্লেখ করে একটি অ্যারে উপাদান অ্যাক্সেস করুন.
                এই স্টেটমেন্টটি গাড়ি এর প্রথম উপাদানের মান অ্যাক্সেস করে:
            */

            String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]); //  outputs: Volvo
            //   দ্রষ্টব্য: অ্যারে ইন্ডেক্স 0 দিয়ে শুরু হয়: [0] হল প্রথম উপাদান। [1] হল দ্বিতীয় উপাদান।
            Console.WriteLine("===========\n");
            /*
                Change an Array Element
                একটি নির্দিষ্ট উপাদানের মান পরিবর্তন করতে, সূচক সংখ্যাটি উল্লেখ করুন:
                cars[0] = "Opel";
            */
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
                    cars1[0] = "Opel";
                    Console.WriteLine(cars1[0]); // outputs: Opel 
                    Console.WriteLine("===========\n");

            //  Array Length
            //  একটি অ্যারে কতগুলি উপাদান রয়েছে তা খুঁজে বের করতে, Length প্রপার্টি ব্যবহার করুন:
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars2.Length);  // Outputs:	 4
            Console.WriteLine("===========\n");


            /* 
             Other Ways to Create an Array
             যদি আপনি C# এর সাথে পরিচিত হন, আপনি new কীওয়ার্ড দিয়ে অ্যারে তৈরি করতে দেখে থাকবেন, 
            এবং সম্ভবত আপনি নির্দিষ্ট আকারের অ্যারেও দেখেছেন। C# এ, অ্যারে তৈরি করার বিভিন্ন উপায় রয়েছে

            // চারটি উপাদানের একটি অ্যারে তৈরি করুন এবং পরে মান যোগ করুন
            string[] cars = new string[4];

            // চারটি উপাদানের একটি অ্যারে তৈরি করুন এবং সঙ্গে সঙ্গে মান যোগ করুন।
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // আকার নির্দিষ্ট না করে চারটি উপাদানের একটি অ্যারে তৈরি করুন।
            string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // নতুন কিওয়ার্ড বাদ দিয়ে এবং আকার নির্দিষ্ট না করে চারটি উপাদানের একটি অ্যারে তৈরি করুন
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            কোন অপশনটি বেছে নেবেন সেটি আপনার উপর নির্ভর করে। 
            আমাদের টিউটোরিয়ালে, আমরা প্রায়ই শেষ অপশনটি ব্যবহার করব, কারণ এটি দ্রুত এবং পড়তে সহজ।


            */

            // একটি অ্যারে ঘোষণা করুন
            string[] cars3;
            // new ব্যবহার করে মান যুক্ত করুন।
            cars3 = new string[] { "Volvo", "BMW", "Ford" };

            // এটি একটি ত্রুটি সৃষ্টি করবে:: cars = {"Volvo", "BMW", "Ford"};
            Console.WriteLine(cars3[0]);  //  outputs: Volvo



            Console.ReadLine();
        }
    }
}
