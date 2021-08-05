using System;

///<summary>Class for player information</summary>
class Player
{
    // shouldn't be able to access player's properties
    private string name { get; set; }
    private float maxHP { get; set; }
    private float hp { get; set; }

    ///<summary> constructor for the player stats</summary>
    public Player(string name = "Player", float maxHP = 100f)
    {
        if (maxHP < 0)
        {
            this.maxHP = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default..");
        }
        this.name = name;
        this.maxHP = maxHP;
        this.hp = maxHP;
    }

    ///<summary> method that prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHP} health");
    }

}