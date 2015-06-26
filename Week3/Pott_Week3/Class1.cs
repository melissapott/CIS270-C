using System;

namespace Pott_Week3
{
	/// <summary>
	/// Melissa Pott
	/// CIS 270
	/// Week 3 Lab
	/// 
	/// This program defines a set of arrays containing various details of 
	/// items in inventory at a gas station.  The user can select to display
	/// the details of a particular item or of all the items.
	/// </summary>

	class InventoryDisplay
	{
		
		static void Main(string[] args)
		{
			//declare arrays for inventory item details
			string[] itemNumber = {"111","222","333","444","555"};
			string[] itemName = {"Washer Fluid","Oil","Soda","Candy","Road Atlas"};
			double[] itemCost = {.70,.80,.50,.50,2.00};
			double[] itemPrice = {.99,1.20,1.00,.75,3.50};
			int[] itemStock = {8,12,48,25,10};
			string[] itemCategory = {"auto","auto","food","food","general"};
			bool itemSelected = false; //used to test if a valid item number has been selected
			string menuChoice = "0";//used to hold the user's menu choice input


			while(menuChoice != "99")//accept input continually until user enters 99
			{
				Console.Write("Enter Item Number, 0 for all items, 99 to quit: ");
				menuChoice = Console.ReadLine();
				
				switch(menuChoice)
				{
					case "0": 
						//all items should be displayed, so walk thru the arrays 
						//and display details for every item
						for(int i = 0; i <= 4; i++)
						{							
							DisplayResults(itemNumber[i],itemName[i],itemCategory[i],itemCost[i],itemPrice[i],itemStock[i]);
							Console.WriteLine("***********************\n");
						}
						Console.WriteLine("\n");
						break;
					case "99": //the user has entered 99, so we can quit
						break;
					default: //the user has entered either an item number or invalid entry
						for(int x = 0; x <= 4; x++)//walk array to determine if item number was entered, if so, print it out
							if (itemNumber[x] == menuChoice)
							{
								DisplayResults(itemNumber[x],itemName[x],itemCategory[x],itemCost[x],itemPrice[x],itemStock[x]);
								itemSelected = true;
								break;
							}//end if
						if (!(itemSelected))//if they didn't enter an item number, then they made an invalid entry 
						{
							Console.WriteLine("Error:  please enter valid item number\n");
						}
						itemSelected = false; //reset the value so we can try again with the next entry
						break;
				}//end switch
			}//end while
		}//end Main

		static void DisplayResults(string itemNumber, string itemName, string itemCategory, double itemCost, double itemPrice, int itemStock)
		{//this routine takes the appropriate values as select in Main and handles the output
			Console.WriteLine("Name: " + itemName + "\n");
			Console.WriteLine("Price: " + itemPrice + "\n");
			Console.WriteLine("Cost: " + itemCost + "\n");
			Console.WriteLine("Category: " + itemCategory + "\n");
			Console.WriteLine("Item Number: " + itemNumber + "\n");
			Console.WriteLine("Stock Quantity: " + itemStock + "\n");
		}//end DisplayResults

	}//end class
}//end namespace
