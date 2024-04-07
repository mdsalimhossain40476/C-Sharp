using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // কমেন্টস ব্যবহার করা যায় সি# কোডকে ব্যাখ্যা করতে এবং তাকে আরও বেশি পড়ার উপযোগী করতে। এটি বিকল্প কোড পরীক্ষা করার সময় কার্যকরীকরণকে প্রতিরোধ করতেও ব্যবহার করা যায়।
            // Single-line Comment
            //এক-লাইনের কমেন্ট দুটি ফরওয়ার্ড স্ল্যাশ (//) দিয়ে শুরু হয়।
            //  // এবং লাইনের শেষের মধ্যে থাকা যেকোনো টেক্সট C# উপেক্ষা করে (কার্যকর করা হবে না)।
        
            Console.WriteLine("Hello World!");     // This is a Single-line Comment

            // Multi-line Comments
            /*
               মাল্টি-লাইন কমেন্ট শুরু হয় /* দিয়ে এবং শেষ হয় * / দিয়ে।
               /* এবং * / এর মাঝের যেকোনো টেক্সট C# উপেক্ষা করবে।

               কোনটি ব্যবহার করবেন তা আপনার উপর নির্ভর করে। সাধারণত, আমরা সংক্ষিপ্ত মন্তব্যের জন্য // ব্যবহার করি, এবং দীর্ঘ মন্তব্যের জন্য /* * / ব্যবহার করি।
               
             */

            Console.WriteLine("Hello World!");

            Console.ReadLine();
            // প্রোগ্রামকে অপেক্ষার অবস্থায় রাখার জন্য এই লাইনটি লিখতে হয়


        }
    }
}
