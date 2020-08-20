using System;

///<summary>Calculate modifiers</summary>
public enum Modifier
{
    ///<summary>Weak modifier</summary>
    Weak = 1,
    ///<summary>Base modifier</summary>
    Base = 2,
    ///<summary>Strongest modifier</summary>
    Strong = 3
}

/// <summary>Modifers applied based on tier</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Calculate health</summary>

public delegate void CalculateHealth(float health);

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    ///<summary>Player hp event handler</summary>
    EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    ///<summary>Player health.</summary>
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
        Console.WriteLine($"{this.name} heals {heal} HP!");
           if (this.hp >= 0)
            this.ValidateHP(this.hp + heal);
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
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }
    ///<summary>Validate Player hp changes</summary>
      public float ApplyModifier(float baseValue, Modifier modifier) 
      {
       return (baseValue * ((float)modifier / 2f));
      }
    ///<summary>Player status</summary>
        private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }

    ///<summary>Check value, warn of any error</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");
    }

    ///<summary>Checks current HP</summary>
    void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp / 4))
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }

}
