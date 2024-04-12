using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Short Hand If...Else (Ternary Operator)
                একটি সংক্ষেপ আছে, যা টারনারি অপারেটর হিসেবে পরিচিত কারণ এটি তিনটি অপারেন্ডে গঠিত। 
                এটি একাধিক লাইনের কোডকে একটি লাইনে প্রতিস্থাপন করতে ব্যবহার করা যেতে পারে। এটি প্রায়ই 
                সহজ If...Else স্টেটমেন্ট প্রতিস্থাপন করতে ব্যবহার করা হয়
            */
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");  //  Output : Good evening.
            }  //  Outputs:    Good evening.
            
                    // লেখার পরিবর্তে।
                    // আপনি সহজেই লিখতে পারেন।
                    // variable = (condition) ? expressionTrue :  expressionFalse;
                    int time1 = 20;
                    string result = (time1 < 18) ? "Good day." : "Good evening.";
                    Console.WriteLine(result);   //  Output : Good evening.
            Console.ReadLine();
        }
    }
}
