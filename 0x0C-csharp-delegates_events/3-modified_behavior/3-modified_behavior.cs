using System;

///<summary>Calculates modifiers.</summary>
public enum Modifier
{
    ///<summary>Weak modifier</summary>
    Weak = 1,
    ///<summary>Base modifier</summary>
    Base = 2,
    ///<summary>Strongest modifier</summary>
    Strong = 3
}

/// <summary>Will apply effect based on tier modifier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Will calculate health.</summary>

public delegate void CalculateHealth(float health);

///<summary> Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Player Class Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Player health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
       ///<summary>Calculate Player damage</summary>
    public void TakeDamage(float damage)
      {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        float newHp = this.hp - damage;
        this.ValidateHP(newHp);
      }
    ///<summary>Calculate Player healing</summary>
 	public void HealDamage(float heal)
	{
		float newHp = this.hp;
		if (heal < 0f)
			heal = 0f;
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		newHp += heal;
		ValidateHP(newHp);
	}
    ///<summary>Value of Player hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else 
            this.hp = newHp;
    }
    ///<summary>Check Player hp modifications</summary>
      public float ApplyModifier(float baseValue, Modifier modifier) 
      {
       return (baseValue * ((float)modifier / 2f));
      }
}
