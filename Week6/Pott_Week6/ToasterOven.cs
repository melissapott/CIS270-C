using System;

namespace Pott_Week6
{
	/// <summary>
	/// ToasterOven is derived from the base class Appliance.  In addition to the properties of the base class,
	/// ToasterOven includes properties for the states of the top and bottom burners, and the toasting
	/// mode selection
	/// </summary>
	public class ToasterOven : Appliance
	{
		private bool topBurnerOn;
		private bool bottomBurnerOn;
		private string toastSetting;

		//constructor
		public ToasterOven(bool top, bool bottom, string setting) : base("Black & Decker", "Countertop Toaster Oven", "black", "kitchen electric", true, false)
        {
			TopBurnerOn = top;
			BottomBurnerOn = bottom;
			ToastSetting = setting;
			
		}

		//property TopBurnerOn
		public bool TopBurnerOn
		{
			get
			{
				return topBurnerOn;
			}
			set
			{
				topBurnerOn = value;
			}
		}//end TopBurnerOn

        //property BottomBurnerOn
		public bool BottomBurnerOn
		{
			get
			{
				return bottomBurnerOn;
			}
			set
			{
				bottomBurnerOn = value;
			}
		}//end BottomBurnerOn

		//property ToastSetting
		public string ToastSetting
		{
			get
			{
				return toastSetting;
			}
			set
			{
				toastSetting = value;
			}
		}//end ToastSetting

		public void Bake()
		{
			topBurnerOn = true;
			bottomBurnerOn = true;
			toastSetting = "bake";
			this.OnOffState = true;
			Console.WriteLine("Unit is baking ... ");
			Console.WriteLine("Top Burner is on? " + topBurnerOn);
			Console.WriteLine("Bottom Burner is on? " + bottomBurnerOn);
			Console.WriteLine("Toast setting is " + toastSetting);
		}//end Bake

		public void Broil()
		{
			topBurnerOn = true;
			bottomBurnerOn = false;
			toastSetting = "broil";
			this.OnOffState = true;
			Console.WriteLine("Unit is broiling ... ");
			Console.WriteLine("Top Burner is on? " + topBurnerOn);
			Console.WriteLine("Bottom Burner is on? " + bottomBurnerOn);
			Console.WriteLine("Toast setting is " + toastSetting);
		}//end Broil

		public void Toast( string setting)
		{
			topBurnerOn = true;
			bottomBurnerOn = true;
			toastSetting = setting;
			this.OnOffState = true;
			Console.WriteLine("Unit is toasting ... ");
			Console.WriteLine("Top Burner is on? " + topBurnerOn);
			Console.WriteLine("Bottom Burner is on? " + bottomBurnerOn);
			Console.WriteLine("Toast setting is " + toastSetting);
		}//end Toast

		public void TurnOff()
		{
			topBurnerOn = false;
			bottomBurnerOn = false;
			toastSetting = "off";
			this.OnOffState = false;
			Console.WriteLine("unit is shutting off ...");
			Console.WriteLine("Top Burner is on? " + topBurnerOn);
			Console.WriteLine("Bottom Burner is on? " + bottomBurnerOn);
			Console.WriteLine("Toast setting is " + toastSetting);
		}//end TurnOff


	}
}
