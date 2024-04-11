using System;


namespace ComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 C# Comparison Operators
                Comparison operators দুটি মান (বা ভেরিয়েবল) তুলনা করতে ব্যবহৃত হয়। এটি প্রোগ্রামিংয়ে গুরুত্বপূর্ণ, 
                কারণ এটি আমাদের উত্তর খুঁজে পেতে এবং সিদ্ধান্ত নিতে সাহায্য করে।

                একটি Comparison রিটার্ন মান হল True বা False। এই মানগুলিকে বুলিয়ান মান হিসাবে পরিচিত করা হয় 
                এবং বুলিয়ান এবং If..Else অধ্যায়ে আপনি এগুলি সম্পর্কে আরও জানতে পারবেন।

                নিম্নলিখিত উদাহরণে, আমরা 5টি 3টির চেয়ে বেশি কিনা তা জানতে বৃহত্তর অপারেটর (>) ব্যবহার করি:

            */

                int x = 5;
                int y = 3;
                Console.WriteLine(x > y);  // 5 3 এর চেয়ে বড় বলে True রিটার্ন করে।
                                           //  Outputs :   True

            int a = 5;
            int b = 3;
            Console.WriteLine(a == b);  // False রিটার্ন করে কারন 5, 3 এর সমান নয়।
                                        //  Outputs :   False

                int c = 5;
                int d = 3;
                Console.WriteLine(c != d);  // returns True because 5 is not equal to 3
                                            //  Outputs :   True

            int e = 5;
            int f = 3;
            Console.WriteLine(e != f);   //সত্যি ফেরত দেয় কারণ 5 এর সাথে 3 সমান নয়।
                                         //  Outputs :   True

                int g = 5;
                int h = 3;
                Console.WriteLine(g < h); // returns False because 5 is not less than 3
                                          //  Outputs :   False

            int i = 5;
            int j = 3;
            Console.WriteLine(i >= j); // returns True because 5 is greater, or equal, to 3
                                       //  Outputs :   True

                int k = 5;
                int l = 3;
                Console.WriteLine(k <= l); // returns False because 5 is neither less than or equal to 3
                                           //  Outputs :   False




            Console.ReadLine();
        }
    }
}
