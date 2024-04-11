using System;


namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               String Concatenation
               + operator টি strings গুলো কে সংযুক্ত করার জন্য ব্যবহার করা যেতে পারে। এটিকে concatenation বলা হয়।
            */
            string firstName = "Md ";
            string lastName = "Salim";
            string name = firstName + lastName;
            Console.WriteLine(name);        // Outputs  :   Md Salim
            //  লক্ষ্য করো যে আমরা প্রিন্টে firstName এবং lastName এর মধ্যে একটি স্পেস তৈরি করার জন্য "John" এর পরে একটি স্পেস যোগ করেছি।

                    //  তুমি দুটি স্ট্রিং কনকাটেনেট করতে string.Concat() মেথডও ব্যবহার করতে পারো:
                    string firstName1 = "Mst ";
                    string lastName1 = "Salina";
                    string name1 = string.Concat(firstName1, lastName1);
                    Console.WriteLine(name1);   // Outputs  :   Mst Salina

            /*
                Adding Numbers and Strings
                সংখ্যা এবং স্ট্রিং যোগ করা

                C# যোগ এবং সংযুক্তকরণ উভয়ের জন্যই + অপারেটর ব্যবহার করে।

                মনে রাখবেন : সংখ্যা যোগ করা হয়। স্ট্রিং সংযুক্ত করা হয়।

                যদি আপনি দুটি সংখ্যা যোগ করেন, তাহলে ফলাফলটি একটি সংখ্যা হবে:
            */
            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);  // z will be 30 (an integer/number)


                    //  যদি আপনি দুটি স্ট্রিং যোগ করেন, ফলাফলটি একটি স্ট্রিং সংযোজন হবে।
                    string a = "10";
                    string b = "20";
                    string c = a + b;
                    Console.WriteLine(c);	// z will be 1020 (a string)

            Console.ReadLine();
        }
    }
}
