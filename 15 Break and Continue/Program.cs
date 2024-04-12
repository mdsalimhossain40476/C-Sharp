using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakandContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                C# Break
                এটি একটি সুইচ স্টেটমেন্ট থেকে "জাম্প আউট" করতে ব্যবহৃত হয়েছিল।

                ব্রেক স্টেটমেন্টটি একটি লুপ থেকে বের হয়ে আসার জন্যও ব্যবহার করা যায়। 

                এই উদাহরণটি লুপ থেকে বের হয়ে আসবে যখন i এর মান 4 হবে।

             */
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }   //  Output :	0	1	2	3
            Console.WriteLine("======= \n");

                        /*
                            C# Continue
                            যদি নির্দিষ্ট শর্ত পূরণ হয় তাহলে Continue স্টেটমেন্ট একটি পুনরাবৃত্তি (লুপে) ভেঙে দেয় এবং লুপে পরবর্তী পুনরাবৃত্তি দিয়ে চলতে থাকে।

                            এই উদাহরণ 4 এর মান এড়িয়ে যায়:

                        */
                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 4)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                        } //Output: 0 1 2 3 4 5 6 7 8 9
            Console.WriteLine("======= \n");
            //Break and Continue in While Loop
            //আপনি break এবং continue ব্যবহার করতে পারেন while loops এর মধ্যে:
            //Break Example
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
                if (a == 4)
                {
                    break;
                }
            }  //   Output :	0	1	2	3
            Console.WriteLine("======= \n");

                    // Continue Example
                    int b = 0;
                    while (b < 10)
                    {
                        if (b == 4)
                        {
                            b++;
                            continue;
                        }
                        Console.WriteLine(b);
                        b++;
                    } // Output: 0 1 2 3 4 5 6 7 8 9


            Console.ReadLine();
        }
    }
}
