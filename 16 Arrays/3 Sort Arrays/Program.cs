using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Sort an Array
            //  অনেক অ্যারে পদ্ধতি পাওয়া যায়, যেমন Sort(), যা একটি অ্যারেকে বর্ণানু ক্রমিক ভাবে বা ক্রমবর্ধমান ক্রমে সাজায়:
            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }	//  Output:	Volvo BMW  Ford  Mazda  1  5  8  9

           Console.WriteLine("====== \n");

                    //  System.Linq Namespace
                    //  System.Linq নেমস্পেসে Min, Max এবং Sum এর মতো অন্যান্য উপযোগী অ্যারে পদ্ধতি পাওয়া যায়:
                    int[] myNumbers1 = { 5, 1, 8, 9 };
                    Console.WriteLine(myNumbers1.Max());  // returns the largest value
                    Console.WriteLine(myNumbers1.Min());  // returns the smallest value
                    Console.WriteLine(myNumbers1.Sum());  // returns the sum of elements
                    //  Output:	9  1   23	

            Console.ReadLine();
        }
    }
}
