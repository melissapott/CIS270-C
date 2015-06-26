using System;

namespace Pott_Week6
{
	/// <summary>
	/// Toothbrush is derived from the Appliance class.  In addition to the properties of the base class,
	/// Toothbrush also includes properties for the states of the battery charger, motor operation and
	/// position of the switch
	/// </summary>
	public class Toothbrush : Appliance
	{
		private bool batteryCharging;
		private bool motorRunning;
		private bool switchOn;

		//constructor
		public Toothbrush(bool battery, bool motor, bool onswitch):base("Braun","Oral-B","White", "Health and Beauty", true, true)
		{
			BatteryCharging = batteryCharging;
			MotorRunning = motorRunning;
			SwitchOn = switchOn;

		}

		//property BatteryCharging
		public bool BatteryCharging
		{
			get
			{
				return batteryCharging;
			}
			set
			{
				batteryCharging = value;
			}
		}//end BatteryCharging

		public bool MotorRunning
		{
			get
			{
				return motorRunning;
			}
			set
			{
				motorRunning = value;
			}
		}//end MotorRunning

		public bool SwitchOn
		{
			get
			{
				return switchOn;
			}
			set
			{
				switchOn = value;
			}
		}//end SwitchOn

		public void BrushTeeth()
		{
			switchOn = true;
			motorRunning = true;
			batteryCharging = false;
			Console.WriteLine("Switch On? = " + switchOn);
			Console.WriteLine("Motor Running? = " + motorRunning);
			Console.WriteLine("Battery Charging? = " + batteryCharging);
		}//end BrushTeeth()

		public void StopBrushing()
		{
			switchOn = false;
			motorRunning = false;
			batteryCharging = true;
			Console.WriteLine("Finished brushing ... ");
			Console.WriteLine("Switch On? = " + switchOn);
			Console.WriteLine("Motor Running? = " + motorRunning);
			Console.WriteLine("Battery Charging? = " + batteryCharging);
		}//end StopBrushing()


	}
}
