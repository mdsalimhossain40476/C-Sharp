using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Loops
                যতক্ষণ একটি নির্দিষ্ট শর্ত পূরণ হয় ততক্ষণ Loops কোডের একটি ব্লক চালানো হয়।

                Loops গুলি সুবিধাজনক কারণ এগুলি সময় বাঁচায়, ভুল কমায় এবং কোডকে আরও পঠনযোগ্য করে তোলে।
                   
                C# While Loop
                যতক্ষণ একটি নির্দিষ্ট শর্ত সত্য থাকে ততক্ষণ while লুপ কোডের একটি ব্লকের মধ্য দিয়ে লুপ করে:

                Syntax 
                while (condition) 
                {
                    // code block to be executed
                }
                    নীচের উদাহরণে, লুপের কোডটি বার বার চলবে, যতক্ষণ না একটি ভেরিয়েবল (i) 5 এর চেয়ে কম হবে:
            */
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }  // Output :	0	1	2	3	4
               //   দ্রষ্টব্য: কন্ডিশন-এ ব্যবহৃত ভেরিয়েবল বাড়াতে ভুলবেন না, অন্যথায় লুপটি কখনই শেষ হবে না!
            Console.WriteLine("-------------------\n");
            /*
                The Do/While Loop
                do/while লুপ হল while লুপের একটি প্রকার। এই লুপটি কন্ডিশন সত্য কিনা পরীক্ষা করার আগে একবার কোড ব্লকটি এক্সিকিউট করবে, 
                তারপর যতক্ষণ কন্ডিশনটি সত্য থাকবে ততক্ষণ লুপটি পুনরাবৃত্তি করবে।

                do 
                {
                  // code block to be executed
                }
                while (condition);

                নিচের উদাহরণটি একটি do/while লুপ ব্যবহার করে। কন্ডিশনটি মিথ্যা হলেও লুপটি কমপক্ষে একবার চালানো হবে, 
                কারণ কন্ডিশনটি পরীক্ষা করার আগেই কোড ব্লকটি চালানো হয়:

            */
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);  // Output :	0	1	2	3	4   5   6   7   8   9



            Console.ReadLine();
        }
    }
}
