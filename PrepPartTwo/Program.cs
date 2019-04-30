using System;

namespace PrepPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
		    int width;
		    int area;

		    Console.WriteLine("What is the length of the rectangle?");
		    length = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("What is the width of the rectangle?");
		    width = Convert.ToInt32(Console.ReadLine());

		    area = length * width;

		    Console.WriteLine("The area of the rectange is {0}", area);
        }
    }
}
