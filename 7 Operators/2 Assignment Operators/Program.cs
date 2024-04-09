using System;


namespace AssignmentOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Assignment Operators
               ভেরিয়েবল গুলিতে মান বরাদ্দ করতে অ্যাসাইনমেন্ট অপারেটরগুলি ব্যবহার করা হয়।
               
               নিচের উদাহরণে, আমরা অ্যাসাইনমেন্ট অপারেটর (=) ব্যবহার করে x নামক একটি ভেরিয়েবলে 5 মান বরাদ্দ করেছি:
               
             */
            int x = 5;
            Console.WriteLine(x);
            Console.WriteLine("------------------- \n");
            int a = 5;
            a += 5;
            Console.WriteLine(a);
            Console.WriteLine("------------------- \n");
            int b = 5;
            b -= 3;
            b = 5 - 3;
            Console.WriteLine(b);
            Console.WriteLine("------------------- \n");
            int c = 5;
            c *= 3;
            c = 5 * 3;
            Console.WriteLine(c);
            Console.WriteLine("------------------- \n");
            int d = 5;
            d /= 3;
            Console.WriteLine(d);
            Console.WriteLine("------------------- \n");
            int f= 5;
            f %= 3;
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
