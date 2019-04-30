using System;

namespace PrepPartThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
		    double gallonsUsed;
		    double mpg;

		    Console.WriteLine("How many miles have you driven?");
		    milesDriven = Convert.ToDouble(Console.ReadLine());
		    Console.WriteLine("How many gallons of gas have you used?");
		    gallonsUsed = Convert.ToDouble(Console.ReadLine());

		    mpg = milesDriven / gallonsUsed;

		    Console.WriteLine("Your mpg is {0}", mpg);
        }
    }
}
