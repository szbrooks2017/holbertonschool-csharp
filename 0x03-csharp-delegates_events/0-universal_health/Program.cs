using System;

///<summary>Class for player information</summary>
class Player
{
    // shouldn't be able to access player's properties
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    ///<summary> constructor for the player stats</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary> method that prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

}