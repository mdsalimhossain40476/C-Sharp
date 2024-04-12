using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                The foreach Loop
                এছাড়াও একটি foreach লুপ আছে, যা একটি অ্যারের মধ্যে উপাদান গুলো লুপ করার জন্য ব্যবহার করা হয়:

                foreach (type variableName in arrayName) 
                {
                  // code block to be executed
                }
                    নিচের উদাহরণটি foreach লুপ ব্যবহার করে cars অ্যারের সকল উপাদান আউটপুট দেয়

            */

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }  //  Output  :	Volvo   BMW   Ford   Mazda

            Console.ReadLine();
        }
    }
}
