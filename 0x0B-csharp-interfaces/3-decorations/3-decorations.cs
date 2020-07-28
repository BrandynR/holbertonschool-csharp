using System;


/// <summary>Simple abstract class.</summary>
public abstract class Base
{
    /// <summary>Name of this object.</summary>
    public string name;

    /// <summary>Show name and type of this object.</summary>
    /// <returns>String containing object's name and type.</returns>
    public override string ToString() {
        return String.Format("{0} is a {1}", this.name, this.GetType().Name);
    }
}


public interface IBreakable
{
    int durability { get; set; }

    void Break();
}
public interface ICollectable
{
    /// <summary>Whether this object is being carried or is still to be found.</summary>
    bool isCollected { get; set; }

    /// <summary>Act like this object has been picked up.</summary>
    void Collect();
}

/// <summary>Sample interface for interactable object.</summary>
public interface IInteractive
{
    /// <summary>Perform tdefault interaction with this object.</summary>
    void Interact();
}


/// <summary>Openable door.</summary>
public class Door : Base, IInteractive
{
    /// <summary>Creates a door with default name.</summary>
    /// <param name="name">The name of this object.</param>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>Try to open door.</summary>
    public void Interact() {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

/// <summary>Destructible decoration.</summary>
public class Decoration : Base, IBreakable, IInteractive
{
    /// <summary><see cref="IBreakable.durability"/></summary>
    public int durability { get; set; } = 1;

    public bool isQuestItem = false;


    /// <summary>Creates a decoration with starting values for properties.</summary>
    /// <param name="name">The name of this item.</param>
    /// <param name="durability">The durability of this item.</param>
    /// <param name="isQuestItem">Whether this is a quest item.</param>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false) {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }


    /// <summary>Inspect item.</summary>
    public void Interact() {
        if (this.durability < 1)
            Console.WriteLine("The {0} has been broken.", this.name);
        else if (this.isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    /// <summary>Damage item.</summary>
    public void Break() {
        this.durability--;
        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}
