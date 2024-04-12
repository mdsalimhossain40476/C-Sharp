using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  C# For Loop & Nested Loops
            /*
                C# For Loop
                যখন আপনি নির্দিষ্ট ভাবে জানেন যে আপনি কোডের একটি ব্লকের মধ্যে কতবার লুপ করতে চান, তখন একটি while লুপের পরিবর্তে for লুপ ব্যবহার করুন:
                for (statement 1; statement 2; statement 3) 
                {
                  // code block to be executed
                }
                স্টেটমেন্ট 1 কোড ব্লকটি কার্যকর করার আগে (একবার) কার্যকর করা হয়।
                স্টেটমেন্ট 2 কোড ব্লকটি কার্যকর করার শর্তটি নির্ধারণ করে।
                স্টেটমেন্ট 3 কোড ব্লকটি কার্যকর হওয়ার পরে (প্রত্যেক সময়) কার্যকর হয়।

             */
            //  নিচের উদাহরণ ০ থেকে ৪ সংখ্যা প্রিন্ট করবে:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }  // Outputs : 0   1   2   3   4   
            Console.WriteLine("============== \n");
            /*
                Example explained
                1.	লুপ শুরু হওয়ার আগে একটি ভেরিয়েবল সেট করে (int i = 0)।

                2.	লুপটি চালানোর জন্য শর্ত নির্ধারণ করে (i 5 এর চেয়ে কম হতে হবে)। 
                    যদি শর্ত সত্য হয়, লুপটি পুনরায় শুরু হবে, যদি এটি মিথ্যা হয়, লুপটি শেষ হবে।

                3.	লুপের মধ্যে কোড ব্লকটি প্রতিবার চালানো হলে একটি মান বাড়িয়ে দেয় (i++)।

            */

                    // Another Example
                    // এই উদাহরণটি কেবল 0 এবং 10 এর মধ্যে সম মানগুলি প্রিন্ট করবে:
                    for (int i = 0; i <= 10; i = i + 2)
                            {
                                Console.WriteLine(i);
                            }  // Output : 2	4	6	8	10
                            Console.WriteLine("============== \n");
            /*
                Nested Loops
                একটি লুপের ভিতরে আরেকটি লুপ রাখাও সম্ভব। এটিকে নেস্টেড লুপ বলা হয়
                "আউটার লুপ"-এর প্রতিটি পুনরাবৃত্তির জন্য "ইনার লুপ" একবার চালিত হবে।
            */
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
            /*
               Outputs:

                     Outer: 1
                     Inner: 1
                     Inner: 2
                     Inner: 3
                    Outer: 2
                     Inner: 1
                     Inner: 2
                     Inner: 3
             */

            Console.ReadLine();
        }
    }
}
