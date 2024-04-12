using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  C# Switch Statements
                 বহু কোড ব্লকগুলির মধ্যে একটি নির্বাচন করার জন্য Switch Statements ব্যবহার করুন।
                
                   Syntax 
                    switch(expression) 
                    {
                        case x:
                        // code block
                        break;
                        case y:
                        // code block
                        break;
                        default:
                        // code block
                        break;
                    }

                এভাবেই এটি কাজ করে।
                1. সুইচ এক্সপ্রেশনটি একবার মূল্যায়ন করা হয়
                2. এক্সপ্রেশনের মানটি প্রতিটি কেসের মানের সাথে তুলনা করা হয়
                3. IF মিল হয়, তাহলে সংযুক্ত কোড ব্লকটি চালানো হয়

            */

            //  নীচের উদাহরণটি সপ্তাহের দিনটির নাম গণনা করতে সপ্তাহের দিন সংখ্যাটি ব্যবহার করে।
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }   //    Outputs:  Thursday

            /*
                    The break Keyword
                    যখন C# একটি ব্রেক কীওয়ার্ডে পৌঁছায়, এটি সুইচ ব্লকের বাইরে বেরিয়ে যায়।

                    এটি ব্লকের ভিতরে আরো কোড এবং কেস পরীক্ষার কার্যক্রম বন্ধ করে দেবে।

                    যখন একটি মিল পাওয়া যায় এবং কাজটি সম্পন্ন হয়, তখন বিরতির সময় এসেছে। আরো পরীক্ষার দরকার নেই।

                    একটি বিরতি অনেক কার্যক্রম সময় বাঁচাতে পারে কারণ এটি সুইচ ব্লকের বাকি সমস্ত কোডের কার্যক্রম কে "অবহেলা" করে।

            */


            Console.ReadLine();
        }
    }
}
