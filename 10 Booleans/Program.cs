using System;
using System.Security.Cryptography;


namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                C# Booleans
                প্রোগ্রামিং-এ প্রায়ই এমন একটি ডাটা টাইপের প্রয়োজন হয় যার মাত্র দুটি মান থাকতে পারে, যেমন:

                হ্যাঁ / না
                অন / অফ
                সত্য / মিথ্যা
                এর জন্য, C# একটি bool ডাটা টাইপ আছে, যার মান হতে পারে সত্য অথবা মিথ্যা।
                Boolean Values
                একটি বুলিয়ান / Boolean টাইপ bool কীওয়ার্ড দ্বারা ঘোষণা করা হয় এবং কেবলমাত্র / শুধুমাত্র true বা false মান গ্রহণ করতে পারে।

            */
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);       // Outputs:    True
            Console.WriteLine(isFishTasty);       // Outputs:    False

            //  যাহোক, কন্ডিশনাল / শর্তাধীন পরীক্ষার জন্য বুলিয়ান এক্সপ্রেশন থেকে বুলিয়ান মান ফেরত দেওয়া আরও সাধারণ (নিচে দেখুন)

                    /*
                        Boolean Expression
                        একটি বুলিয়ান এক্সপ্রেশন মান তুলনা করে একটি বুলিয়ান মান ফেরৎ দেয়: সত্য বা মিথ্যা।

                        এটি লজিক তৈরি করতে এবং উত্তর খুঁজে পেতে উপকারী।

                        উদাহরণ স্বরূপ, আপনি একটি তুলনামূলক অপারেটর ব্যবহার করতে পারেন, যেমন গ্রেটার দ্যান (>) অপারেটর, কোনো এক্সপ্রেশন (বা একটি ভ্যারিয়েবল) সত্য কিনা তা জানতে:
                    */

                    int x = 10;
                    int y = 9;
                    Console.WriteLine(x > y); // সত্য রিটার্ন করে, কারণ 10টি 9টির চেয়ে বেশি।
                    // Output: True

            // অথবা আরো সহজ
            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
            //  Output: True

                    //  নীচের উদাহরণে, আমরা একটি মতপ্রকাশ/এক্সপ্রেশন মূল্যায়ন করতে সমান (= =) অপারেটর ব্যবহার করি:
                    int a = 10;
                    Console.WriteLine(a == 10); // সত্য ফেরত দেয়, কারণ x এর মান 10 এর সমান
                    //  Output: True

            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
            //  Output: False

                    /*
                        Real Life Example
                        চলুন একটি "বাস্তব জীবনের উদাহরণ" সম্পর্কে ভাবা যাক যেখানে আমাদের খুঁজে বের করতে হবে 
                        যে একজন ব্যক্তি ভোট দেওয়ার জন্য যথেষ্ট বয়স্ক কিনা।

                        নীচের উদাহরণে, আমরা >= তুলনামূলক অপারেটরটি ব্যবহার করি যাতে বের করা যায় বয়স (২৫) 
                        ভোটদানের বয়স সীমা, যা ১৮ এ সেট করা হয়েছে, তার চেয়ে বেশি বা সমান কিনা।

                    */
                    int myAge = 25;
                    int votingAge = 18;
                    Console.WriteLine(myAge >= votingAge);  // সত্য ফিরিয়ে দেয়, অর্থাৎ 25 বছর বয়সীদের ভোট দেওয়ার অনুমতি আছে!    
                                                            //  Output: True


            //  যদি myAge 18 এর সমান বা বেশি হয় তবে আউটপুট হিসেবে "ভোট দেওয়ার জন্য যথেষ্ট বয়স্ক!" প্রদর্শন করুন। অন্যথায় আউটপুট হিসেবে "ভোট দেওয়ার জন্য যথেষ্ট বয়স্ক নয়" প্রদর্শন করুন।
            int myAge1 = 25;
            int votingAge1 = 18;

            if (myAge1 >= votingAge1)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
            //  Output: Old enough to vote!
            //  একটি এক্সপ্রেশনের বুলিয়ান মান হল সমস্ত C# তুলনা এবং শর্তের ভিত্তি।

            Console.ReadLine();
        }
    }
}
