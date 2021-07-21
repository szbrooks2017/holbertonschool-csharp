using System;

namespace Enemies
{
    ///<summary>Rerpresents Zombie class</summary>
    class Zombie
    {
        public int health;
        private string name = "(No name)";
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }

        public string Name
        {
            get {return (name);}
            set {name = value;}
        }

        public int GetHealth()
        {
            return health;
        }
    }
}