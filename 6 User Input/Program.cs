using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Get User Input
            /*
                 আপনি ইতিমধ্যেই শিখেছেন যে Console.WriteLine() ব্যবহার করা হয় মান (প্রিন্ট) আউটপুট করার জন্য। 
                 এখন আমরা ব্যবহারকারীর ইনপুট পেতে Console.ReadLine() ব্যবহার করব।
               
               নিম্নলিখিত উদাহরণে, ব্যবহারকারী তার নিজের ইউজারনেম ইনপুট করতে পারে, 
              যা userName ভেরিয়েবলে সংরক্ষিত হয়। তারপর আমরা userName এর মান প্রিন্ট করি:               
           */
            // আপনার ব্যবহারকারী নাম টাইপ করুন এবং এন্টার চাপুন।
            Console.WriteLine("Enter username:");

            // একটি স্ট্রিং ভেরিয়েবল তৈরি করুন এবং কীবোর্ড থেকে ব্যবহারকারীর ইনপুট নিন এবং এটি ভেরিয়েবলে সংরক্ষণ করুন।
            string userName = Console.ReadLine();

            // ভেরিয়েবল (userName) এর মান প্রিন্ট করুন, যা ইনপুট মান প্রদর্শন করবে।
            Console.WriteLine("User name is: " + userName);
            /*
                Outputs  	:	Enter user name:
                                Salim
               User name is :  User name is: Salim

             */


            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            /*
                Outputs	   :	Enter your age:
                                42
               Your age is :    Your age is: 42

            */


            Console.ReadLine();
        }
    }
}
