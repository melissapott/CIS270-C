using System;
using System.IO;


namespace Pott_Week7
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Week 7 lab
	/// 
	/// This program will accept input from a file specified by the user.  Each line of this file
	/// is read into an object called "record" which takes 5 arguements.  An array of these objects 
	/// is created, and the WriteRecord method of each object is called to create the output.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		///
		[STAThread]
		static void Main(string[] args)
		{
			string inputFile; //holds the file name input by the user

			Console.WriteLine("please enter the full path and file name of the file you wish to process");
			inputFile = Console.ReadLine();

			if (!File.Exists(inputFile))
			{
				//if we can't find the file, then we end the program with an error message
				Console.WriteLine("Invalid file name entry.  Program ending.");
			}//end if
			else
			{
				//the file has been found, so we can go ahead and declare the necessary variables
				FileStream input = new FileStream(inputFile,FileMode.Open,FileAccess.Read);;
				StreamReader reader = new StreamReader(input);
				string fileLine;//will be used to read a line in from the file
				string delimitingChars = " ;,:";//the program will accept these values as delimiting characters
				char[] delimiter = delimitingChars.ToCharArray();//holds delimiters as character array
							
				//find out how many records are in the file, and assign that value to the lineCount variable
				int lines = FindLineCount(inputFile);
				
				int lineCount = 0;//will be used as a subscript value for the array of records

				Record[] arrayOfRecords = new Record[lines];//declare an array to hold our Record objects

				//read thru the file again, and create a Record object for each line in the file
				while (reader.Peek() > 0)
				{
					fileLine = reader.ReadLine();
					string[] fileLineArray = fileLine.Split(delimiter);
					arrayOfRecords[lineCount] = new Record(fileLineArray[0].PadRight(10),fileLineArray[1].PadRight(10),fileLineArray[2].PadRight(10),fileLineArray[3].PadRight(10),fileLineArray[4].PadRight(10),
						int.Parse(fileLineArray[5]),int.Parse(fileLineArray[6]));
					lineCount ++;	

				}//end while
				
				CreateHeaders();
			
				//iterate through the array of Record items and call the WriteRecord method for each one
				foreach(Record salesItem in arrayOfRecords)
				{
					salesItem.WriteRecord();
				}//end foreach

			}//end if/else
			
			
		}//end Main()

		static void CreateHeaders()
	{
		//set up output headers
		Console.WriteLine("\nSales Person\t\tAutomobile\t\t");
		Console.WriteLine("First     Last      Make      Model     Year      Cost\tPrice\n");
	}//end CreateHeaders()

		static int FindLineCount(string fileName)//run through the file to see how many lines it has
		{
			FileStream fileLineCount = new FileStream(fileName,FileMode.Open, FileAccess.Read);
			StreamReader lineCounter = new StreamReader(fileLineCount);
			int lineCount = 0;

			while(lineCounter.Peek() > 0)
			{
				lineCounter.ReadLine();
				lineCount ++;
			}

			lineCounter.Close();
			return lineCount;
		
		}//end FindLineCount

	}
}
