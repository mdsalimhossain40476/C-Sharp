using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  C# এ একটা ভেরিয়েবল অবশ্যই নির্দিষ্ট একটা ডাটা টাইপ হতে হবে:

            int myNum = 5;                              // integer (whole number)
            double myDoubleNum = 5.99D;                 // floating point number
            char myLetter = 'D';                        // character
            bool myBool = true;                         // boolean
            string myText = "Hello";                    // string

            Console.WriteLine(myNum);                  //  Output  : 5
            Console.WriteLine(myDoubleNum);            //  Output  : 5.99
            Console.WriteLine(myLetter);               //  Output  : D
            Console.WriteLine(myBool);                 //  Output  : True
            Console.WriteLine(myText);                 //  Output  : Hello
            /*
                  একটি ডেটা টাইপ পরিবর্তনশীল মানের সাইজ এবং টাইপ নির্দিষ্ট করে।
               
                 সংশ্লিষ্ট পরিবর্তনশীলের জন্য সঠিক ডেটা টাইপ ব্যবহার করা গুরুত্বপূর্ণ; ত্রুটি এড়াতে, সময় এবং মেমরি বাঁচাতে,
                 কিন্তু এটি আপনার কোডকে আরও বজায় রাখা এবং পড়ার উপযোগী করবে। সবচেয়ে সাধারণ ডেটা টাইপগুলি হল:
               
               DataType	   Size                 	Description

               int	       4 bytes	    -2,147,483,648 থেকে 2,147,483,647 পর্যন্ত পূর্ণ সংখ্যা সংরক্ষণ করে।
               long	       8 bytes	    -9,223,372,036,854,775,808 থেকে 9,223,372,036,854,775,807 পর্যন্ত পূর্ণ সংখ্যা স্টোর করে
               float	   4 bytes	    ভগ্নাংশ সংখ্যা সঞ্চয় করে। 6 থেকে 7 দশমিক সংখ্যা সঞ্চয় করার জন্য যথেষ্ট
               double	   8 bytes	    ভগ্নাংশ সংখ্যা সংরক্ষণ করে। 15টি দশমিক সংখ্যা সংরক্ষণের জন্য যথেষ্ট।
               bool	       1 bit	    সত্য বা মিথ্যা মান সংরক্ষণ করে।
               char	       2 bytes  	একক উদ্ধৃতি চিহ্ন দ্বারা বেষ্টিত একটি একক অক্ষর/বর্ণ সংরক্ষণ করে।
                           
            */

            //  Numbers
            //  সংখ্যাগুলি দুটি গ্রুপে বিভক্ত করা হয়েছে:

            /*
               পূর্ণসংখ্যাগুলি পূর্ণ সংখ্যা সঞ্চয় করে, ধনাত্মক বা ঋণাত্মক (যেমন 123 বা -456), দশমিক ছাড়া। 
               Valid/ন্যায়সঙ্গত/ বৈধ টাইপগুলি হল int এবং long। আপনার কোন টাইপটি ব্যবহার করা উচিত,
              এটি নির্ভর করে সংখ্যাসূচক মানের উপর।

               
               ফ্লোটিং পয়েন্ট টাইপগুলি ভগ্নাংশ অংশ সহ সংখ্যাগুলি উপস্থাপন করে,
               যার মধ্যে একটি বা একাধিক দশমিক রয়েছে। Valid/ন্যায়সঙ্গত/ বৈধ টাইপগুলি হল float এবং double।
               
              C# এ অনেক সংখ্যক টাইপ থাকলেও, সংখ্যার জন্য সর্বাধিক ব্যবহৃত হল int (পূর্ণ সংখ্যার জন্য) এবং double (দশমিক সংখ্যার জন্য)।
             
            */

            //  Integer Types
            //  int
            /*
                int ডাটা টাইপ -2147483648 থেকে 2147483647 পর্যন্ত পূর্ণসংখ্যা সংরক্ষণ করতে পারে। সাধারণত, 
               এবং আমাদের টিউটোরিয়ালে, int ডাটা টাইপই পছন্দের ডাটা টাইপ যখন আমরা সংখ্যামূলক মান নিয়ে ভেরিয়েবল তৈরি করি।             
            */
            int myNum1 = 100000;
            Console.WriteLine(myNum1);   //  Output  :	100000

            //  Long
            /*
                Long ডাটা টাইপ -9223372036854775808 থেকে 9223372036854775807 পর্যন্ত পূর্ণ সংখ্যা
                ধারণ করতে পারে। এটি ব্যবহার করা হয় যখন int মানটি ধারণ করার জন্য যথেষ্ট বড় নয়।
                লক্ষ্য করুন যে আপনাকে মানটি "L" দিয়ে শেষ করতে হবে:  
            */
            long myNum2 = 15000000000L;
            Console.WriteLine(myNum2);    //  Output  :	15000000000

            // Floating Point Types
            /*
                যখনই আপনার দশমিক সংখ্যার প্রয়োজন হবে যেমন 9.99 বা 3.14515, 
                তখন আপনার একটি Floating Point Types ব্যবহার করা উচিত।
               
               Float এবং double ডাটা টাইপ ভগ্নাংশ সংখ্যা সঞ্চয় করতে পারে।
               মনে রাখবেন যে আপনার ফ্লোটের জন্য মানটি "F" এবং ডাবলের জন্য "D" দিয়ে শেষ করতে হবে:
               
            */
            float f1 = 35e5F;
            double d1 = 12E4D;
            Console.WriteLine(f1);    //  Output  :	3500000   
            Console.WriteLine(d1);    //  Output  :	120000

            //  Booleans
            /*
                Boolean /বুলিয়ান ডাটা টাইপকে bool কীওয়ার্ড দিয়ে ঘোষণা করা হয় 
                এবং এটি শুধুমাত্র true বা false মান নিতে পারে:
            */
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False  
            //  বুলিয়ান মানগুলো বেশিরভাগ ক্ষেত্রেই শর্তসাপেক্ষ/শর্তাধীন পরীক্ষার জন্য ব্যবহৃত হয়।

            //  Characters
            //  Char ডেটা টাইপটি একটি একক অক্ষর সংরক্ষণ করতে ব্যবহার করা হয়। অক্ষরটি অবশ্যই একক ' ' উদ্ধৃতি চিহ্ন দ্বারা বেষ্টিত হতে হবে, যেমন 'A' বা 'c':
            char myGrade = 'B';
            Console.WriteLine(myGrade);   // Outputs : B 

            //  Strings
            /*
                String / স্ট্রিং ডাটা টাইপটি একটি ক্রম অনুসারে সাজানো অক্ষর (টেক্সট) 
                সংরক্ষণের জন্য ব্যবহৃত হয়। স্ট্রিং মানগুলি ডাবল কোট  "H" দ্বারা বেষ্টিত থাকতে হবে:
             */
            string greeting = "Hello World";
            Console.WriteLine(greeting);    //  Output  :   Hello World                                           



            Console.ReadLine();

        }
    }
}
