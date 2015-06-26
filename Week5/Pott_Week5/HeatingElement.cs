using System;

namespace Pott_Week5
{
	///	<summary>
	///	A heating element is an	electrical coil	that is	used to	generate
	///	heat in	a cooking appliance.  It is	placed on top or below the 
	///	cooking	surface	and	can	be either on or	off.
	///	</summary>
	///	
	public class HeatingElement
	{
		
		private string location;
		private string state;

		
		public HeatingElement(string loc)
		{
			SetHeatingElement(loc, "off");
		}

		public void SetHeatingElement(string loc, string sta)
		{
			location = loc;
			state = sta;
			}//end SetHeatingElement

		public string ReturnElementStatus()
		{
		return "The element on the " + location + " is " + state;
		}//end ReturnElementStatus

		public string Location
		{
			get
			{
				return location;
			}
			set
			{
				location = (value == "top" || value == "bottom" ? value : "top");
			}
		}// end Location

		public string State
		{
			get
			{
				return state;
			}
			set
			{
				state = (value == "on" || value == "off" ? value : "off");
			}
		}//end State



	}//end class HeatingElement
}//end namespace
		