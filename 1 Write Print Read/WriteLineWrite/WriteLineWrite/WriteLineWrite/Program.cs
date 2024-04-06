using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLineWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            //আপনি যতগুলি চান ততগুলি WriteLine () পদ্ধতি যোগ করতে পারেন। লক্ষ্য করুন যে এটি প্রতিটি পদ্ধতির জন্য একটি নতুন লাইন যোগ করবে:
            Console.WriteLine(3 + 3);
            //আপনি সংখ্যাও পাঠাতে পারেন, এবং গাণিতিক গণনা করতে পারেন:

            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
            /*  এখানে একটি Write() পদ্ধতি রয়েছে, যা WriteLine() - এর অনুরূপ।
                একমাত্র পার্থক্য হল এটি আউটপুটের শেষে একটি নতুন লাইন যুক্ত করে না।
            */
            Console.ReadLine();
        }
    }
}
