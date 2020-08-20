using System;

namespace Enemies
{
	///<summary>Creates zombie class</summary>
	public class Zombie
	{
		///<summary>public field for health of zombie</summary>
		public int health;
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
	}
}
