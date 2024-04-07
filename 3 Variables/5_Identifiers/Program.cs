using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Identifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  সব C# ভেরিয়েবলকে একক / অদ্বিতীয় নাম দ্বারা চিহ্নিত করা আবশ্যক।
            //  এই একক / অদ্বিতীয় নাম গুলো কে আইডেন্টিফায়ার বলা হয়।
            //  আইডেন্টিফায়ার গুলো সংক্ষিপ্ত নাম (যেমন x এবং y) অথবা আরও বর্ণনামূলক নাম (বয়স, যোগফল, মোট আয়তন) হতে পারে।
            //  নোট	:	 সহজবোধ্য/বোধগম্য এবং সমর্থনীয়/রক্ষণযোগ্য কোড তৈরি করতে বর্ণনামূলক নাম ব্যবহার করার সুপারিশ করা হয়: 

            
            int minutesPerHour = 50;             // Good
            int m = 70;                          // ঠিক আছে, কিন্তু m আসলে কী তা বোঝা খুব সহজ নয়

            Console.WriteLine(minutesPerHour);  // Good
            // Output: 70
            Console.WriteLine(m);               // OK, but not so easy to understand what m actually is
            //  Output:  70


            /*
                ভেরিয়েবলের নামকরণের সাধারণ নিয়মগুলি হল:
               
               1.	নাম গুলিতে অক্ষর, সংখ্যা এবং আন্ডারস্কোর চিহ্ন (_) থাকতে পারে।
               2.	নাম গুলি একটি অক্ষর বা আন্ডারস্কোর দিয়ে শুরু হতে হবে।
               3.	নাম গুলি ছোট হাতের অক্ষর দিয়ে শুরু হওয়া উচিত এবং এতে whitespace/সাদা স্থান থাকতে পারে না।
               4.	নাম গুলি কেস-সেনসিটিভ ("myNum" এবং "mynum" হল বিভিন্ন ভেরিয়েবল)।
               5.	সংরক্ষিত শব্দগুলি (যেমন সি# কীওয়ার্ড, যেমন int বা double) নাম হিসাবে ব্যবহার করা যায় না।                                                                             
               
            */
            Console.ReadLine();

        }
    }
}
