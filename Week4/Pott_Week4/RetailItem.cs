using System;

namespace Pott_Week4
{
	/// <summary>
	/// Summary description for RetailItem.
	/// 
	/// Melissa Pott
	/// CIS270
	/// Week 4 Lab
	/// May 22, 2005
	/// 
	/// The RetailItem class creates an object with properties of itemNumber, itemName,
	/// itemCategory, itemCost, itemPrice, and itemStock.  Three constructors are provided 
	/// which take either no arguments, arguments for all parameters, or arguments for the 
	/// itemNumber, itemName, and itemCategory parameters
	/// 
	/// The included itemDisplay function formats the object properties for output along 
	/// with appropriate labels.
	/// </summary>
	public class RetailItem
	{
		private string itemNumber, itemName, itemCategory;
		private double itemCost, itemPrice;
		private int itemStock;

		//Default constuctor
		public RetailItem()
		{
			SetRetailItem("item number","item name","item category",0.0,0.0,0);
		}//end default constructor
		
		
		//All variable constructor
		public RetailItem(string num, string nam, string cat, double cos, double pri, int sto)
		{
			SetRetailItem(num,nam,cat,cos,pri,sto);
		}//end all variable constructor


		//multi-variable constructor
		public RetailItem(string num, string nam, string cat)
		{		
			SetRetailItem(num,nam,cat,0.0,0.0,0);
		}//end multi-variable constructor

		
		//invoke set methods for all RetailItem properties
		public void SetRetailItem(string num, string nam, string cat, double cos, double pri, int sto)
		{
			ItemNumber = num;
			ItemName = nam;
			ItemCategory = cat;
			ItemCost  = cos;
			ItemPrice = pri;
			ItemStock = sto;
			
		}//end SetRetailItem

		
		//property ItemNumber
		public string ItemNumber
		{
			get
			{
				return itemNumber;
			}

			set
			{
				itemNumber = value;
			}
		}//end ItemNumber

		//property ItemName
		public string ItemName
		{
			get
			{
				return itemName;
			}
			set
			{
				itemName = value;
			}
		}// end ItemName

		//property ItemCategory
		public string ItemCategory
		{
			get
			{
				return itemCategory;
			}
			set
			{
				itemCategory = value;
			}
		}//end ItemName

		//property ItemCost
		public double ItemCost
		{
			get
			{
				return itemCost;
			}
			set
			{
				itemCost = (value >= 0 ? value: 0.0);
			}
		}//end ItemCost

		//property ItemPrice
		public double ItemPrice
		{
			get
			{
				return itemPrice;
			}
			set
			{
				itemPrice = (value >= 0 ? value: 0.0);
			}
		}//end ItemPrice

		//property ItemStock
		public int ItemStock
		{
			get
			{
				return itemStock;
			}
			set
			{
				itemStock = (value >=0 ? value:0);
			}
		}//end ItemStock

		public string ItemDisplay()
		{
			string strOutput;

			strOutput = "You have chosen to list information on the " + ItemName + "\n";
			strOutput += "Name: " + ItemName + "\n";
			strOutput += "Price: " + ItemPrice + "\n";
			strOutput += "Cost: " + ItemCost + "\n";
			strOutput += "Category: " + ItemCategory + "\n";
			strOutput += "Item Number: " + ItemNumber + "\n";
			strOutput += "Stock Quantity: " + ItemStock + "\n";

			return strOutput;

		}//end ItemDisplay



	}
}
