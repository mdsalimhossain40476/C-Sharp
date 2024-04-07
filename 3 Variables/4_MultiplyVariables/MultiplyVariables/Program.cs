using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Many Variables
            /*
               একই ধরনের একাধিক ভেরিয়েবল ঘোষণা করতে, কমা-বিচ্ছিন্ন ( , ) তালিকা ব্যবহার করুন:
            */
            int x = 15, y = 20, z = 50;
            Console.WriteLine(x + y + z);  //  Output  :	85

            // একটি লাইনে একাধিক ভেরিয়েবলে একই মান অ্যাসাইন করতে পারেন:
            int a, b, c;
            a = b = c = 30;
            Console.WriteLine(a + b + c);    // Output  :	90                                                                             



            Console.ReadLine();
        }
    }
}
