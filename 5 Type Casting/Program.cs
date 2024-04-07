using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  C# Type Casting
            /*
                 Type Casting হল যখন আপনি একটি ডেটা টাইপের মান অন্য টাইপে নির্ধারণ করেন।
               C# এ, দুই ধরনের কাস্টিং আছে:
               
               Implicit Casting (স্বয়ংক্রিয়ভাবে) - একটি ছোট টাইপকে একটি বড় টাইপের সাইজে রূপান্তর করে
               char -> int -> long -> float -> double
               
               Explicit Casting (ম্যানুয়ালি) - একটি বড় টাইপকে একটি ছোট টাইপের সাইজে রূপান্তর করে
               double -> float -> long -> int -> char
            */

             // Implicit Casting : একটি ছোট আকারের টাইপকে একটি বড় আকারের টাইপে পাঠানোর সময় স্বয়ংক্রিয়ভাবে ইমপ্লিসিট ক্যাস্টিং করা হয়:
            int myInt = 9;
            double myDouble = myInt;             // Automatic casting: int to double

            Console.WriteLine(myInt);            // Outputs  :   9    
            Console.WriteLine(myDouble);         // Outputs  :   9    

            //   Explicit Casting
            //   একটি মানের সামনে প্রথম বন্ধনী / বন্ধনী তে টাইপটি রেখে Explicit Casting ম্যানুয়ালি করতে হবে:
            double myDouble1 = 9.70;
            int myInt1 = (int)myDouble;           // Manual casting: double to int
            Console.WriteLine(myDouble1);         // Outputs  :   9.70    
            Console.WriteLine(myInt1);            // Outputs  :   9 

            //  Type Conversion Methods
            /*
                 বিল্ট-ইন পদ্ধতিগুলি ব্যবহার করে ডেটা টাইপগুলিকে স্পষ্টভাবে রূপান্তর করাও সম্ভব,
                যেমন Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) 
                এবং Convert.ToInt64 (long):
            */

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2));            // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));            // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));          // convert double to int
            Console.WriteLine(Convert.ToString(myBool));            // convert bool to string

            Console.ReadLine();

        }
    }
}
