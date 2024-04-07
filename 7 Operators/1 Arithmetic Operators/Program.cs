using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Arithmetic Operators
            //  Arithmetic Operators সাধারণ গাণিতিক কার্য সম্পাদনের জন্য ব্যবহৃত হয়:
            
            /*
                  Operator	       Name	                        Description	                          Example	
                  +	            Addition	               দুটি মানকে একসাথে যোগ করে।	          x + y	
            */
            
               int x = 5;
               int y = 3;
               Console.WriteLine(x + y);  //  Output : 8

            /*  
              Operator            Name                        Description                              Example
                 -	         Subtraction	        একটি মান থেকে অন্য মান বাদ দেয়।	           x - y
             */

            int a = 5;
            int b = 3;
            Console.WriteLine(a - b);  // Output :  2

            /*
               Operator            Name                    Description                                     Example
                 *	           Multiplication	       দুটি মানের গুণফল বের করে।	              x * y	
           */
            
            int c = 5;
            int d = 3;
            Console.WriteLine(c * d);   // Output :  15 

            /*
                   Operator            Name                   Description                                         Example
                     /	           Division	         একটি মানকে অন্য একটি দ্বারা ভাগ করুন।   	           x / y	
           */

            
            int e = 12;
            int f = 3;
            Console.WriteLine(e / f);  //  Output :  4

            /*
                   Operator            Name                  Description                                 Example
                     %	         Modulus	             বিভাগের বাকি ফেরত দেয়।	                  x % y	
            */

            
            int g = 5;
            int h = 2;
            Console.WriteLine(g % h);   //  Output :  1

            /*
                   Operator           Name                     Description                                      Example
                     ++	          Increment	          একটি ভেরিয়েবলের মান 1 দ্বারা বৃদ্ধি করে।	              x++	
            */

            
            int i = 5;
            i++;
            Console.WriteLine(i);  // Output :  6

            /*
                   Operator           Name                     Description                                  Example
                     --	          Decrement	           একটি ভেরিয়েবলের মান ১ দ্বারা হ্রাস করে।	           x--	               
            */

            
               int j = 5;
                   j--;
               Console.WriteLine(j);   // Output :  4

            Console.ReadLine();

        }
    }
}
