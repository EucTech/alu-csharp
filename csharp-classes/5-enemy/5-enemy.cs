using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    public class Zombie
    {
        // Stores the health of the zombie.
        private int health;

        // Stores the name of the zombie.
        private string name = "(No name)";

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with the specified health.</summary>
        /// <param name="value">The starting health. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>Gets or sets the name of the zombie.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>Gets the health of the zombie.</summary>
        /// <returns>The current health value.</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>Returns a string that represents the current zombie.</summary>
        /// <returns>A string containing the zombie's name and total health.</returns>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
