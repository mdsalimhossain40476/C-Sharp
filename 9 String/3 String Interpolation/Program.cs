using System;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                C# String Interpolation
                String সংযুক্তির আরেকটি বিকল্প হল String Interpolation, যা স্ট্রিংয়ে ভেরিয়েবলের মানকে 
                প্লেসহোল্ডারে প্রতিস্থাপন করে। লক্ষ্য করুন যে আপনাকে সংযুক্তির মতো স্পেস সম্পর্কে চিন্তা করতে হবে না।

                এছাড়াও মনে রাখবেন String Interpolation পদ্ধতি ব্যবহার করার সময় আপনাকে ডলার সাইন ($) ব্যবহার করতে হবে।

            */

            string firstName = "Md ";
            string lastName = "Salim";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);    // Outputs My full name is:	Md Salim

            Console.ReadLine();
        }
    }
}
