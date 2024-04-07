using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               WriteLine() পদ্ধতিটি প্রায়ই কনসোল উইন্ডোতে ভেরিয়েবলের মান প্রদর্শন করতে ব্যবহৃত হয়।
               
               একটি ভেরিয়েবল এবং টেক্সট একত্রিত করতে, + অক্ষরটি ব্যবহার করুন:
               
            */
            string name = "Md Salim Hossain";
            Console.WriteLine("Hello " + name);   //  Output  :	Hello Md Salim Hossain

            /*
               আপনি + ক্যারেক্টারটি ব্যবহার করে একটি ভেরিয়েবলকে আরেকটি ভেরিয়েবলের সাথে যোগ করতে পারেন।
            */
            string firstName = "Md ";
            string lastName = "Salim";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName); //  Output: Md Salim

            /*
                সংখ্যার মানের জন্য, +চিহ্নটি গাণিতিক অপারেটর হিসাবে কাজ করে(লক্ষ্য করুন যে আমরা এখানে int(পূর্ণসংখ্যা) ভেরিয়েবল ব্যবহার করি):
            */
            int x = 10;
            int y = 15;
            Console.WriteLine(x + y);  //  Output  :	25
            /*
                  উপরের উদাহরণ থেকে, আপনি আশা করতে পারেন:
               
               x 5 মান সংরক্ষণ করে
               y 6 মান সংরক্ষণ করে
               তারপর আমরা x + y এর মান প্রদর্শন করতে WriteLine() পদ্ধতি ব্যবহার করি, যা 25 ।        
               
            */

            Console.ReadLine();

        }
    }
}
