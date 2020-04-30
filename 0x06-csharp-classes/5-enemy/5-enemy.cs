using System;

namespace Enemies
{
	///<summary>Creates zombie class</summary>
	public class Zombie
	{
		///<summary>field for health of zombie</summary>
		private int health;
		///<summary>constructor for zombie</summary>
		public Zombie()
		{
			health = 0;
		}
		///<summary>constructor for zombie with value input</summary>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			else
			{
				health = value;
			}
		}
		///<summary>field name of zombie</summary>
		private string name = "(No name)";
		///<summary>property Name of zombie</summary>
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		///<summary>Method to reutrn health of zombie</summary>
		public int GetHealth()
		{
			return health;
		}
		///<summary>Overide .toString method that prints the Zombie object’s attributes to stdout</summary>
		public override string ToString()
		{
			return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
		}
	}
}
