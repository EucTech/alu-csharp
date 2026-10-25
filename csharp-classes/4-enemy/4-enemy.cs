using System;

namespace Enemies
{
    /// <summary>Defines a zombie.</summary>
    public class Zombie
    {
        /// <summary>The zombie's health.</summary>
        private int health;

        /// <summary>The zombie's name.</summary>
        private string name = "(No name)";

        /// <summary>Initializes a new Zombie with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new Zombie with the given health.</summary>
        /// <param name="value">The starting health; must be 0 or greater.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>Gets or sets the zombie's name.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>Returns the zombie's health.</summary>
        /// <returns>The value of health.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
