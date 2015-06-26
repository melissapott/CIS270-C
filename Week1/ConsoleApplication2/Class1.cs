using System;

namespace ConsoleApplication2
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Lab 1b
	/// May 1, 2005
	/// This program sums 2 numbers entered, but only if number is equal to 100
	/// </summary>
	class ExtremeSumming
	{
		
		
		static int Main(string[] args)
		{
			int int_number;  //to hold user-supplied integers
			int sum = 0;  //the sum of all the input integers
			int i;  //counter
			string data;

			Console.WriteLine("Welcome to YOUR summing program");

			//propmt user and accept input for first number
			Console.Write("Enter an integer: "); 
			data = Console.ReadLine();  
			int_number = int.Parse(data);

			if (int_number == 100) //only sum if number is equal to 100
				sum = sum + int_number;

			//prompt user and accept input for second number
			Console.Write("Enter an integer: ");
			data = Console.ReadLine();
			int_number = int.Parse(data);

			if (int_number == 100) //only sum if number is equal to 100
				sum = sum + int_number;

			Console.WriteLine("The sum of your 2 numbers is " + sum); //output result

			return 0;

		} //end main
	}//end class
}//end program
