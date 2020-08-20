using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Base class</summary>
abstract class Base
{
    public string name = "";

    ///<summary>Override ToString method</summary>
    public override string ToString()
    {
        string _string = name + " is a " + this.GetType().Name;
        return _string;
    }
}

///<summary>IInteractive interface</summary>
interface IInteractive
{
    void Interact();
}

///<summary>IBreakable interface</summary>
interface IBreakable
{
    int durability {get; set;}
    void Break();
}

///<summary>ICollectable interface</summary>
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

///<summary>TestObject class</summary>
class Door : Base, IInteractive
{
    ///<summary>Door constructor</summary>
    public Door(string _name = "Door")
    {
        name = _name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}
