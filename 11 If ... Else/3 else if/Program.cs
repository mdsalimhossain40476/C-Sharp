using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    C# The else if Statement
                    যদি প্রথম শর্তটি মিথ্যা হয় তাহলে নতুন শর্ত নির্দিষ্ট করতে else if বিবৃতি ব্যবহার করুন।
                    if (condition1)
                    {
                      // যদি condition1 সত্য হয় তবে ব্লক কোডটি কার্যকর করতে হবে
                    } 
                    else if (condition2) 
                    {
                      // যদি condition1 মিথ্যা এবং condition2 সত্য হয় তাহলে কোডের ব্লকটি কার্যকর করা হবে।
                    } 
                    else
                    {
                      // যদি condition1 মিথ্যা এবং condition2 মিথ্যা হয় তাহলে ব্লক কোডটি কার্যকর হবে
                    }

            */


            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            /*
                উদাহরণ ব্যাখ্যা করা হলো
                উপরের উদাহরণে, সময় (22) 10 এর চেয়ে বেশি, তাই প্রথম শর্তটি মিথ্যা। পরের শর্ত, 
                অন্যথায় যদি স্টেটমেন্টে, মিথ্যা, তাই আমরা অন্যথায় শর্তে যাই কারণ শর্ত1 এবং শর্ত2 
                উভয়ই মিথ্যা - এবং স্ক্রীনে "শুভ সন্ধ্যা" প্রিন্ট করি। 

               যাইহোক, যদি সময় 14 হয়, তাহলে আমাদের প্রোগ্রাম "শুভ দিন" প্রিন্ট করবে।

            */
            Console.ReadLine();
        }
    }
}
