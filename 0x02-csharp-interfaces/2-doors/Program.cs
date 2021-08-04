using System;

///<summary> Base class</summary>
abstract class Base
{
    ///<summary> public property</summary>
    public string name { get; set; }

    ///<summary>method that overrides ToString</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string name ="Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}