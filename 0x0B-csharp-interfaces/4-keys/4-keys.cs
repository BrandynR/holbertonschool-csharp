using System;


/// <summary>Abstract class.</summary>
public abstract class Base
{
    /// <summary>Name of object</summary>
    public string name;

    /// <summary>name and type of object.</summary>
    /// <returns>String containing object's name and type.</returns>
    public override string ToString() {
        return String.Format("{0} is a {1}", this.name, this.GetType().Name);
    }
}


/// <summary>Interface for a breakable object.</summary>
public interface IBreakable
{
    /// <summary>Durability of object before breaking</summary>
    int durability { get; set; }

    /// <summary>Break the object</summary>
    void Break();
}

/// <summary>Interface for a collectible object.</summary>
public interface ICollectable
{
    /// <summary>WCheck if object is being carried or is yet to be found.</summary>
    bool isCollected { get; set; }

    /// <summary>Act as though object has been picked up.</summary>
    void Collect();
}

/// <summary>Interface for an interactable object.</summary>
public interface IInteractive
{
    /// <summary>Perform interaction with this object.</summary>
    void Interact();
}


/// <summary>Openable door.</summary>
public class Door : Base, IInteractive
{
    /// <summary>Create a door with a default name.</summary>
    /// <param name="name">Name of this object.</param>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>Try to open door.</summary>
    public void Interact() {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

/// <summary>A destructible decoration.</summary>
public class Decoration : Base, IBreakable, IInteractive
{
    /// <summary><see cref="IBreakable.durability"/></summary>
    public int durability { get; set; }

    /// <summary>Check: is this item essential to game progress</summary>
    public bool isQuestItem;


    /// <summary>Create decoration w/ starting values for properties.</summary>
    /// <param name="name">Name of this item.</param>
    /// <param name="durability">Durability of this item.</param>
    /// <param name="questItem">Check: if it is a quest item.</param>
    public Decoration(string name="Decoration", int durability=1, bool questItem=false) {
        if (durability < 1)
            throw new ArgumentException("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = questItem;
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

/// <summary>Collectible key.</summary>
public class Key : Base, ICollectable
{
    /// <summary>Check: if this is a carried key or hidden one.</summary>
    public bool isCollected { get; set; }

    /// <summary>Create key with starting values for properties.</summary>
    /// <param name="name">Object's name.</param>
    /// <param name="isCollected">Check: if object has been collected.</param>
    public Key(string name="Key", bool isCollected=false) {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Pick up key.</summary>
    public void Collect() {
        if (this.isCollected)
            Console.WriteLine("You have already picked up the {0}.", this.name);
        else
            Console.WriteLine("You pick up the {0}.", this.name);
        this.isCollected = true;
    }
}
