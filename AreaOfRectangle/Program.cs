using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string length;
            string width;
            double area;
            double user_length;
            double user_width;

            Console.WriteLine("Enter length of your rectangle");
            length = Console.ReadLine();
            user_length = double.Parse(length);

            Console.WriteLine("Enter width of your rectangle");
            width = Console.ReadLine();

            user_width = double.Parse(width);
            area = user_length * user_width;
            Console.WriteLine("The area of your rectangle is " + area);
  
        }
    }
}
