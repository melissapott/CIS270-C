using System;

namespace Pott_Week6
{
	/// <summary>
	/// Summary description for Appliance.
	/// </summary>
	public abstract class Appliance
	{
		private string applianceMake;
		private string applianceModel;
		private string applianceColor;
		private string applianceType;
		private bool pluggedIn;
		private bool onOffState;



		//constructor
		public Appliance(string make, string model, string color, string type, bool plugged, bool state)
		{
			Make = make;
			Model = model;
			Color = color;
			Type = type;
			PluggedIn = plugged;
			OnOffState = state;

		}

		//property Make
		public string Make
		{
			get
			{
				return applianceMake;
			}
			set
			{
				applianceMake = value;
			}
		}//end Make

		//property Model
		public string Model
		{
			get
			{
				return applianceModel;
			}
			set
			{
				applianceModel = value;
			}
		}//end Model

		//property Color
		public string Color
		{
			get
			{
				return applianceColor;
			}
			set
			{
				applianceColor = value;
			}
		}//end Color

		//property Type
		public string Type
		{
			get
			{
				return applianceType;
			}
			set
			{
				applianceType = value;
			}
		}//end Type

		//property PluggedIn
		public bool PluggedIn
		{
			get
			{
				return pluggedIn;
			}
			set
			{
				pluggedIn = value;
			}
		}//end PluggedIn

		//property OnOffState
		public bool OnOffState
		{
			get
			{
				return onOffState;
			}
			set
			{
				onOffState = value;
			}
		}//end OnOffState

		public void ApplianceStats()
		{
			Console.WriteLine ("Make = " + applianceMake);
			Console.WriteLine ("Model = " + applianceModel);
			Console.WriteLine ("Color = " + applianceColor);
			Console.WriteLine ("Type = " + applianceType);
			Console.WriteLine ("Plugged in = " + pluggedIn);
			Console.WriteLine ("On Off State = " + onOffState);
		}

        
	}//end class
}
