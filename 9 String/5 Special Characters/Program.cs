using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                C# Special Characters
                কারণ স্ট্রিং অবশ্যই উদ্ধৃতি  "J"  চিহ্নের মধ্যে লেখা উচিত, সি# এই স্ট্রিং ভুল বুঝবে এবং একটি ত্রুটি তৈরি করবে:
                string txt = "We are the so-called "Vikings" from the north.";
                এই সমস্যা এড়ানোর সমাধান হল, ব্যাকস্ল্যাশ এস্কেপ ক্যারেক্টার ব্যবহার করা।

                ব্যাকস্ল্যাশ (\) এস্কেপ ক্যারেক্টার বিশেষ ক্যারেক্টারকে স্ট্রিং ক্যারেক্টারে পরিণত করে:
                Escape character	Result	         Description 
                \'	                  '	           Single quote / একক উদ্ধৃতি
                \"	                  "	           Double quote / ডবল  উদ্ধৃতি
                \\	                  \	           Backslash / ব্যাকস্ল্যাশ
            */

            //  \" সিকুয়েন্সটি / ধারাবাহিক বস্তুসমূহ একটি স্ট্রিংয়ে একটি ডাবল " কোট যুক্ত করে।
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            // Output: We are the so-called "Vikings" from the north.


                    //  \' ক্রমটি / সিকুয়েন্সটি একটি স্ট্রিংয়ে একটি একক উদ্ধৃতি যুক্ত করে
                    string txt0 = "It\'s alright.";
                    Console.WriteLine(txt0);
                    //Output: It’s alright.


             //  \\  সিকুয়েন্স একটি স্ট্রিংয়ে একটি একক ব্যাকস্ল্যাশ যুক্ত করে।
             string txt1 = "The character \\ is called backslash.";
             Console.WriteLine(txt1);
            // Output: The character \ is called backslash.

                    /*
                            C# এ অন্যান্য উপকারী এস্কেপ ক্যারেক্টার হল:
                            Code	Result	        
                            \n	    New Line	
                   
                     */
                    string txt2 = "Hello\nWorld!";
                    Console.WriteLine(txt2);

            /*
                    Code	Result	        
                    \t	    Tab
            */
            string txt3 = "Hello\tWorld!";
            Console.WriteLine(txt3);

                   /* Code           Result	        
                    \b            Backspace
                   */
                    string txt4 = "Hel\blo World!";
                    Console.WriteLine(txt4);

            Console.ReadLine();
        }
    }
}
