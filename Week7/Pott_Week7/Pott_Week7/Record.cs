using System;

namespace Pott_Week7
{
	/// <summary>
	/// Summary description for Record.
	/// </summary>
	
	public class Record
	{
		private string firstName;
		private string lastName;
		private string carMake;
		private string carModel;
		private string carYear;
		private int dealerCost;
		private int salePrice;


	

		//constructor
		public Record(string firstNameValue, string lastNameValue, string carMakeValue, string carModelValue,
			string carYearValue, int dealerCostValue, int salePriceValue)

		{
			FirstName = firstNameValue;
			LastName = lastNameValue;
			CarMake = carMakeValue;
			CarModel = carModelValue;
			CarYear = carYearValue;
			DealerCost = dealerCostValue;
			SalePrice = salePriceValue;
		}//end constructor

		public void WriteRecord()
		{
			Console.WriteLine(firstName  + lastName + carMake +  carModel +  carYear +  dealerCost + "\t" + salePrice);
		}

		//property FirstName
		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}//end FirstName

		//property LastName
		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}//end LastName

		//property CarMake
		public string CarMake
		{
			get
			{
				return carMake;
			}
			set
			{
				carMake = value;
			}
		}//end CarMake

		//property CarModel
		public string CarModel
		{
			get
			{
				return carModel;
			}
			set
			{
				carModel = value;
			}
		}//end CarModel

		//property CarYear
		public string CarYear
		{
			get
			{
				return carYear;
			}
			set
			{
				carYear = value;
			}
		}//end CarYear

		//property DealerCost
		public int DealerCost
		{
			get
			{
				return dealerCost;
			}
			set
			{
				dealerCost = value;
			}
		}//end DealerCost

		//property SalePrice
		public int SalePrice
		{
			get
			{
				return salePrice;
			}
			set
			{
				salePrice = value;
			}
		}//end SalePrice
	}
}
