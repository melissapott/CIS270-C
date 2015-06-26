using System;

namespace Pott_Week6
{
	/// <summary>
	/// CanOpener is derived from the Appliance class.  In addition to the properties in the base class,
	/// it also has properties representing the lever position and the operational state of the motor.
	/// </summary>
	public class CanOpener : Appliance
	{
		private string leverPosition;
		private bool motorTurning;

		//constructor
		public CanOpener(string lever, bool motor):base("Acme","MightyCan","Harvest Gold", "Kitchen Electric", true, false)
		{
			LeverPosition = leverPosition;
			MotorTurning = motorTurning;

		}

		//property LeverPosition
		public string LeverPosition
		{
			get
			{
				return leverPosition;
			}
			set
			{
				leverPosition = value;
			}
			
		}//end LeverPosition

		//property motorTurning
		public bool MotorTurning
		{
			get
			{
				return motorTurning;
			}
			set
			{
				motorTurning = value;
			}
			
		}//end MotorTurning

		public void OpenCan()
		{
			leverPosition = "down";
			motorTurning = true;
			this.OnOffState = true;
			Console.WriteLine("Lever is " + leverPosition);
			Console.WriteLine("Motor is turning? " + motorTurning);
		}//end OpenCan()

		public void StopOpening()
		{
			leverPosition = "up";
			motorTurning = false;
			this.OnOffState = false;
			Console.WriteLine("Can is open ... ");
			Console.WriteLine("Lever is " + leverPosition);
			Console.WriteLine("Motor is turning? " + motorTurning);
		}//end StopOpening()
	}
}
