using System;

namespace Pott_Week6
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Week 6 Lab
	/// 
	/// This is a demonstration of class inheritance and usage.  Three classes of appliances are 
	/// instantiated with various parameters and their various methods are called to show data input 
	/// and output.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			CanOpener canOpener = new CanOpener("up", false);
			Toothbrush toothbrush = new Toothbrush(true, false, false);
			ToasterOven toasterOven = new ToasterOven(false,false,"off");
			
			int userChoice;
			string ovenChoice;

			do
			{
				Console.WriteLine("Choose an appliance to use...");
				Console.WriteLine("1.  Can Opener");
				Console.WriteLine("2.  Toothbrush");
				Console.WriteLine("3.  Toaster Oven");
				Console.WriteLine("4.  Quit");
				userChoice = int.Parse(Console.ReadLine());

				switch(userChoice)
				{
					case 1 : 
						canOpener.ApplianceStats();
						canOpener.OpenCan();
						canOpener.StopOpening();
						canOpener.ApplianceStats();
						break;
						
					case 2 :
						toothbrush.ApplianceStats();
						toothbrush.BrushTeeth();
						toothbrush.StopBrushing();
						toothbrush.ApplianceStats();
						break;

					case 3 :
						toasterOven.ApplianceStats();
						Console.WriteLine("Enter desired oven usage ... bake, broil, light, medium, or dark");
						ovenChoice = Console.ReadLine();
					switch (ovenChoice)
					{
						case "bake" : 
							toasterOven.Bake();
							break;
						case "broil" :
							toasterOven.Broil();
							break;
						case "light" :
							toasterOven.Toast("light");
							break;
						case "medium" :
							toasterOven.Toast("medium");
							break;
						case "dark" :
							toasterOven.Toast("dark");
							break;
					}//end switch(ovenChoice)
						toasterOven.TurnOff();
						toasterOven.ApplianceStats();
						break;

				}//end switch

			}while (userChoice != 4);
			
		}//end Main()

		

	}
}
