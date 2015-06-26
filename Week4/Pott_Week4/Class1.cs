using System;

namespace Pott_Week4
{
	/// <summary>
	/// Melissa Pott
	/// CIS270
	/// Week 4 Lab
	/// May 22, 2005
	/// 
	/// This application demonstrates the use of abstract data type "RetailItem"
	/// by creating objects using each of the available constructors, using the 
	/// class' mutator functions to set values of the properties, and using the 
	/// ItemDisplay member function to format the ojects for output.
	/// 
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			RetailItem itemOne, itemTwo, itemThree, itemFour, itemFive;

			//create object using the default constructor
			itemOne = new RetailItem();

			//create objects using the multi-argument constructor with all values
			itemTwo = new RetailItem("111","Washer Fluid","automotive",.70,1.19,8);
			itemThree = new RetailItem("222","Oil","automotive",.80,1.29,24);

			//create objects using multi-argument constructor with some values 
			itemFour = new RetailItem("333","Soda","food");
			itemFive = new RetailItem("444","Candy","food");

			//load values into the object built with the default constructor
			itemOne.ItemName = "Road Atlas";
			itemOne.ItemNumber = "555";
			itemOne.ItemCategory = "general";
			itemOne.ItemCost = 2.00;
			itemOne.ItemPrice = 3.50;
			itemOne.ItemStock = 3;


			//load values into the objects built with the multi-argument constructor
			itemFour.ItemCost = .50;
			itemFour.ItemPrice = 1.00;
			itemFour.ItemStock = 48;

			itemFive.ItemCost = .45;
			itemFive.ItemPrice = .75;
			itemFive.ItemStock = 20;


			//generate output for all items
			Console.Write(itemOne.ItemDisplay());
			Console.WriteLine("************************\n");
			Console.Write(itemTwo.ItemDisplay());
			Console.WriteLine("************************\n");
			Console.Write(itemThree.ItemDisplay());
			Console.WriteLine("************************\n");
			Console.Write(itemFour.ItemDisplay());
			Console.WriteLine("************************\n");
			Console.Write(itemFive.ItemDisplay());
		

		}//end Main
	}//end Class1
}
