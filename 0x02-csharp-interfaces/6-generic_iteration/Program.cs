using System;
using System.Collections;
using System.Collections.Generic;

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

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected is false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
    }
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

class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (durability < 0)
        {
            Console.WriteLine("The {0} has been broken.", this.name);
        }
        else
        {
            if (isQuestItem is true)
            {
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
            }
            else
            {
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
            }
        }
    }
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", this.name);
        }
    }
}

class Objs<T> : IEnumerable<T>
{
    ///<summary>Method that lists all objects, iterate through and execute</summary>
    // create list
    //iterate through each object
    //return the list
    List<T> newlist = new List<T>();

    public void Add(T obj)
    {
        newlist.Add(obj);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T obj in newlist)
        {
            yield return obj;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}