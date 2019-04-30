using System;

namespace PrepPartFour
{
    static class Program
    {
        public static bool Contains(this string searchable, string search, StringComparison comparisonType)
	    {
		    //checks to see in 'search' is found within 'aliceQuote' but ignores casing
		    //returns 'True' or 'False'
            return searchable?.IndexOf(search, comparisonType) >= 0;
	    }
        static void Main(string[] args)
        {
            string aliceQuote = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?";
		    string search;
		    bool found;

		    Console.WriteLine("What are you searching for?");
		    search = Console.ReadLine();

		    //calls the method 'Contains' and stores the value of 'True' or 'False' into 'found'
		    found = aliceQuote.Contains(search, StringComparison.InvariantCultureIgnoreCase);

		    if(found)
		    {
			    Console.WriteLine("Your string was found.");
		    }
		    else
		    {
			    Console.WriteLine("Your string was NOT found.");
		    }
        }
    }
}
