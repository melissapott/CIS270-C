using System;




//Toaster Oven
//The toaster oven is a small electric kitchen appliance that is used to 
//bake, broil, or toast foods.  In the toast mode, the user can set the oven 
//for light, medium, or dark, and based on that setting, the oven will cook with
//both top and bottom heating elements for a certain amount of time.  The bake
//mode allows the user to set a certain temperature, and the unit will 
//maintain that cooking temperature using both the top and bottom elements
//until the user switches the unit off.  Broil mode is similar to bake, except
//that only the top heating element is used.
//
//Objects involved in simulating this machine and their attributes include:
//heating elements - we have 2:  one top, one bottom; either can be on or off
//temperature knob - can be set from 200 to 500 degrees
//toasting timer knob - can be set at light, medium or dark
//operation switch - can be set at off, toast, bake, or broil
//thermostat - reads the internal temperature of unit, can be 0 to 500 degrees
//
//more general attributes of the toaster oven which do not influence the
//operation of the oven include:
//brand, model, door state(open or closed), color
//
//Some general methods for simulating the operation of a toaster oven would include:
//Bake - operate both heating elements at the desired temperature until the user switches
//the unit off.
//Broil - operate the top heating element until the user switches the unit off.
//Toast - operate both heating elements for a predetermined length of time.

namespace Pott_Week5
{
	/// <summary>
	/// Summary description for Class1.
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
				UserMenu();
			
		
		}//end Main()


		//The Bake method requires two heating elements and a temperature
		//selected by the user.  It will operate until the user turns it off
		static void Bake()
		{
			int temperature;	
			int endBake = 1;

			HeatingElement top, bottom;
			top = new HeatingElement("top");
			bottom = new HeatingElement("bottom");

			Console.WriteLine("Please enter the desired temperature: ");
			temperature = int.Parse(Console.ReadLine());

			top.State = "on";
			bottom.State = "on";

		    Console.WriteLine("You are now baking...");
			Console.WriteLine(top.ReturnElementStatus());
			Console.WriteLine(bottom.ReturnElementStatus());
			Console.WriteLine("the temperature is " + temperature + " degrees");
			
			do
			{
				Console.WriteLine("Don't forget to turn off the oven by entering 0");
				endBake = int.Parse(Console.ReadLine());
			}while (endBake > 0);

			
			
		}//end Bake()

		
		//the broil method requires one burner operating on the top and operates until
		//the user turns the oven off
		static void Broil()
		{
			int endBroil = 1;
		
			HeatingElement top, bottom;
			top = new HeatingElement("top");
			bottom = new HeatingElement("bottom");

			top.State = "on";
			bottom.State = "off";

			Console.WriteLine("You are now broiling...");
			Console.WriteLine(top.ReturnElementStatus());
			Console.WriteLine(bottom.ReturnElementStatus());
			
			do
			{
				Console.WriteLine("Don't forget to turn off the oven by entering 0");
				endBroil = int.Parse(Console.ReadLine());
			}while (endBroil > 0);

		
		}//end Broil()

		
		//the toast method operates with both heating elements and will turn off
		//at a set time depending on the user selection of light, medium or dark toast
		static void Toast()
		{
			int toastSetting;
			int toastTime=0;
			

			Console.WriteLine("How would you like your toast cooked?");
			Console.WriteLine("1. light\n2. medium\n3. dark");
			toastSetting = int.Parse(Console.ReadLine());

			switch(toastSetting)
			{
				case 1 : toastTime = 5;
					Console.Write("toasting");
					break;
				case 2 : toastTime = 10;
					Console.Write("toasting");
					break;
				case 3 : toastTime = 15;
					Console.Write("toasting");
					break;
				default : toastTime = 30;
					Console.Write("hope you like burnt toast");
					break;
			}//end switch

			for (int t=0; t <= toastTime; t++)
			{
					Console.Write("...");
			}

			HeatingElement top, bottom;

			top = new HeatingElement("top");
			bottom = new HeatingElement("bottom");
		
		}//end Toast()

		
		//user menu lists the possible choices of operation modes of the oven
		static void UserMenu()
		{
			int userSelection;

			Console.WriteLine("Enter the number of your choice of operation:");
			Console.WriteLine("1.  Bake");
			Console.WriteLine("2.  Broil");
			Console.WriteLine("3.  Toast");

			userSelection = int.Parse(Console.ReadLine());

			switch(userSelection)
			{
				case 1 : Bake();
					break;
				case 2 : Broil();
					break;
				case 3 : Toast();
					break;
				default : Console.WriteLine("No valid selection made");
					break;
			}//end switch

		}//end UserMenu()
	}//end Class1


}
