using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               যদি আপনি না চান যে অন্যরা (বা আপনি নিজে) বিদ্যমান মানগুলিকে ওভাররাইট করুন, 
               তাহলে আপনি ভেরিয়েবল টাইপের সামনে const কীওয়ার্ডটি যোগ করতে পারেন।ওয়ার্ড যোগ করতে পারেন।
             */

            const int myNum = 15;
            //myNum = 20;
            Console.WriteLine(myNum);
            /*
                যখন আপনি চান যে একটি ভেরিয়েবল সবসময় একই মান ধরে রাখবে, যাতে অন্যরা (বা আপনি নিজে) আপনার কোডটি নষ্ট করতে না পারে তখন const কিওয়ার্ডটি কাজে লাগে। একটি উদাহরণ যাকে প্রায়ই একটি ধ্রুবক হিসাবে উল্লেখ করা হয়, তা হল PI (3.14159...)।
               
               দ্রষ্টব্য: আপনি মান বরাদ্দ না করে একটি ধ্রুবক ভেরিয়েবল ঘোষণা করতে পারবেন না। যদি আপনি করেন, তাহলে একটি ত্রুটি ঘটবে: একটি const ফিল্ডের জন্য একটি মান প্রদান করা প্রয়োজন।
               
            */

            Console.ReadLine();
        }
    }
}
