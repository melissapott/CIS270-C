using System;

namespace Pott_Week2
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Week 2 Lab
	/// May 8, 2005
	/// 
	/// This application will generate a table of numbers from 1 to 256
	/// and the equivalent values in hexadecimal, octal, and binary
	/// </summary>
	class NumberTable
	{
		
		static void Main(string[] args)
		{
			Console.WriteLine("Decimal\tHex.\tOctal\tBinary"); //set up headings

			//call each conversion method for 1 thru 256 and print results
			for(int i=1;i<=256;i++)
			{
				Console.WriteLine(i+"\t"+ HexConversion(i) + "\t" + OctConversion(i) + "\t" + BinConversion(i));
			}

		}//end main

		static string BinConversion(int quotient)
		{
			//use repeated division by two starting with original number and working
			//down to 0, the remainders of each division are used to build a string
			//which will represent the binary equivalent of the original decimal number

			int remainder=0;
			string binary="";

			while(quotient > 0)
			{
				remainder = quotient%2;
				quotient = quotient / 2;
				binary = String.Format("{0}",remainder) + binary;
			}//end while
	
			return binary;

		}//end BinConversion

		static string OctConversion(int quotient)
		{
			//use repeated division by eight starting with original number and working
			//down to 0, the remainders of each division are used to build a string
			//which will represent the octal equivalent of the original decimal number

			int remainder=0;
			string octal="";

			while(quotient > 0)
			{
				remainder = quotient % 8;
				quotient = quotient / 8;
				octal = String.Format("{0}",remainder) + octal;
			}//end while

			return octal;

		}//end OctConversion

		static string HexConversion(int quotient)
		{
			//use repeated division by 16 starting with the original number and working
			//down to 0, the remainders of each division are used to build a string
			//which will represent the hexadecimal equivalent of original decimal number

			int remainder=0;
			string hex="", letters="";

			while(quotient > 0)
			{
				remainder = quotient % 16;
				quotient = quotient / 16;
				
				//we need to use letters to represent values between decimal 10 & 15
				switch(remainder)
				{
					case 10:  letters = "A";
						hex = letters + hex;
						break;
					case 11:  letters = "B";
						hex = letters + hex;
						break;
					case 12:  letters = "C";
						hex = letters + hex;
						break;
					case 13:  letters = "D";
						hex = letters + hex;
						break;
					case 14:  letters = "E";
						hex = letters + hex;
						break;
					case 15:  letters = "F";
						hex = letters + hex;
						break;
					default:
						hex = String.Format("{0}",remainder) + hex;
						break;
				}//end switch
			}//end while

			return hex;

		}// end HexConversion

	}//end class
}
