using System;

namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Comparison অপারেটরের মতোই, আপনি Logical অপারেটরের সাহায্যেও 
               সত্য বা মিথ্যা মানের জন্য পরীক্ষা করতে পারেন।
            */


            //   &&  Logical and     :   যদি উভয় বিবৃতি সত্য হয় তাহলে True রিটার্ন
            int x = 5;
            Console.WriteLine(x > 3 && x < 10); // সত্য ফেরত দেয় কারণ ৫টি ৩টির থেকে বড় এবং ৫টি ১০টির থেকে ছোট
                                                // Outputs :    True

            //  ||  Logical or      :       যদি একটি স্টেটমেন্ট সত্য হয় তবে True রিটার্ন করে।
            int a = 5;
                    Console.WriteLine(a > 3 || a < 4); // সত্য ফেরত দেয় কারণ শর্তগুলোর একটি সত্য (5, 3 থেকে বড়, কিন্তু 5, 4 থেকে ছোট নয়)।
                                                       // Outputs :    True

            //  !  Logical not      :       ফলাফলটিকে উল্টানো, যদি ফলাফলটি True হয় তবে False ফিরিয়ে দেয়।
            int y = 5;
            Console.WriteLine(!(y > 3 && y < 10)); // ফলস রিটার্ন করে কারণ ! (Not) ব্যবহার করা হয় ফলাফলটি বিপরীত করতে।
                                                   // Outputs :    True


            Console.ReadLine();
        }
    }
}
