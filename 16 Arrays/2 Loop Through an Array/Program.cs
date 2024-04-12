using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopThroughanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Loop Through Arrays
                আপনি লুপের মাধ্যমে অ্যারের উপাদানগুলির মধ্যে দিয়ে যেতে পারেন,
                এবং লুপ কতবার চলবে তা নির্দিষ্ট করার জন্য Length প্রপার্টি ব্যবহার করতে পারেন।

                নিচের উদাহরণটি cars অ্যারে এর সব উপাদানকে আউটপুট দেয়:

            */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }    // Output:	Volvo BMW  Ford  Mazda
            Console.WriteLine("===== \n ");
            /*  The foreach Loop
              একটি foreach Loop ও রয়েছে, যা একটি অ্যারে তে উপাদানের মধ্যে Loop করতে একচেটিয়া ভাবে ব্যবহৃত হয় হয়:
              foreach (type variableName in arrayName) 
              {
                // code block to be executed
              }
            */

            // নীচের উদাহরণটি একটি foreach লুপ ব্যবহার করে cars অ্যারে তে থাকা সকল উপাদানকে আউটপুট দেয়:
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars1)
            {
                Console.WriteLine(i);
            } // Output: Volvo BMW  Ford Mazda
            /*
                উপরের উদাহরণটি এভাবে পড়া যেতে পারে: cars এ প্রতিটি স্ট্রিং উপাদানের জন্য 
                (i হিসাবে ডাকা হয় - ইনডেক্সের মতো), i এর মান প্রিন্ট করুন।

                যদি আপনি for লুপ এবং foreach লুপের তুলনা করেন, আপনি দেখবেন যে foreach পদ্ধতিটি লেখা সহজ, 
                এটি কোনো কাউন্টারের প্রয়োজন হয় না (Length প্রপার্টি ব্যবহার করে), এবং এটি আরও পঠনযোগ্য।	

            */


            Console.ReadLine();
        }
    }
}
