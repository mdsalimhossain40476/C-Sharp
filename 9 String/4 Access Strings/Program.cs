using System;


namespace AccessStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    C# Access Strings
                    আপনি বর্গ বন্ধনী [ ] এর মধ্যে এর ইনডেক্স নম্বর ব্যবহার করে একটি স্ট্রিং-এর ক্যারেক্টার গুলি অ্যাক্সেস করতে পারেন।

                    এই উদাহরণটি myString-এর প্রথম ক্যারেক্টারটি প্রিন্ট করে।

                    দ্রষ্টব্য: স্ট্রিং ইন্ডেক্স 0 থেকে শুরু হয়: [0] হল প্রথম অক্ষর। [1] হল দ্বিতীয় অক্ষর, ইত্যাদি।
            */
            string myString = "Hello ";
            Console.WriteLine(myString[0]);  // Outputs "H"

                    //  এই উদাহরণ myString এর দ্বিতীয় অক্ষর (1) প্রিন্ট করে:
                    string myString1 = "Hello ";
                    Console.WriteLine(myString1[1]);  // Outputs "e"

            //  একটি স্ট্রিং-এর একটি নির্দিষ্ট ক্যারেক্টারের ইনডেক্স পজিশনটিও আপনি খুঁজে পেতে পারেন, IndexOf() পদ্ধতিটি ব্যবহার করে:
            string myString2 = "Hello";
            Console.WriteLine(myString2.IndexOf("e"));

                    /*
                        আরেকটি উপকারী পদ্ধতি হল Substring(), যা একটি স্ট্রিং থেকে ক্যারেক্টার নিষ্কাশন করে, 
                        নির্দিষ্ট ক্যারেক্টার পজিশন/ইন্ডেক্স থেকে শুরু করে, এবং একটি নতুন স্ট্রিং ফেরত দেয়। 
                        এই পদ্ধতিটি প্রায়ই সুনির্দিষ্ট ক্যারেক্টার পজিশন পেতে IndexOf() এর সাথে একসাথে ব্যবহার করা হয়:
                    */
                    string name = "John Doe";                                       // Full name
                    int charPos = name.IndexOf("D");                                // Location of the letter D 
                    string lastName = name.Substring(charPos);                      // Get last name
                    Console.WriteLine(lastName);                                    // Print the result

            Console.ReadLine();
        }
    }
}
