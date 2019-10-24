using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Enter name below:");
            input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!");
                //Console.ReadLine();
        }
    }
}
