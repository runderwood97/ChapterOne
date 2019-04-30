using System;

namespace PrepPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

		    Console.WriteLine("What is your name?");
		    name = Console.ReadLine();

		    Console.WriteLine("Hello {0}, I hope you have a great day.", name);
        }
    }
}
