using System;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice;
            string user_str;
            //int found_str;

            alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";
            
            Console.WriteLine("Enter a string to search for within the first sentence:");
            user_str = Console.ReadLine();

            int comparison = String.Compare(alice, user_str, comparisonType: StringComparison.OrdinalIgnoreCase);
            //found_str = alice.IndexOf(user_str);

            if (comparison >= 0)
                Console.WriteLine("String was found");
            else
                Console.WriteLine("String not found");
         
        }
    }
}
