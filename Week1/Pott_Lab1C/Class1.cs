using System;

namespace Pott_Lab1C
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Lab 1C
	/// May 1, 2005
	/// This program will display corresponding inches, feet and centimeters
	/// based on a user-entered value in inches, for the user's value as well
	/// as 5 inches less and 5 inches more than the entered value.
	/// </summary>
	class InchConversion
	{
		
		public static int Main(string[] args)
		{
			double inches, centimeters, feet; //declarations
			string data;  //user entered value
			int i;  //counter

			//prompt for and accept data entry
			Console.Write("Please enter a value in inches: "); 
			data = Console.ReadLine();


			Console.WriteLine("Inches\tCentimeters\tFeet"); //set up column headings

			//calculate and output each set of calculations - there will be 11 lines
			for (i = -5; i <= 5; i++)
			{
				//formulas:  centimeters = inches * 2.54, feet = inches / 12
				inches = double.Parse(data) + i;
				centimeters = inches * 2.54;
				feet = inches / 12;
				Console.Write("{0:f2}",inches + "\t"); //output inches
				Console.Write("{0:f2}",centimeters + "\t\t"); //output centimeters
				Console.WriteLine("{0:f2}",feet); //output feet
			}//end for
		
			return 0;
		}//end Main
	}//end class
}//end program
