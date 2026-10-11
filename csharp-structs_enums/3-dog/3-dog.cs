/// <summary>Dog rating values.</summary>
enum Rating
{
    Good,
    Great,
    Excellent
}

/// <summary>Represents a dog.</summary>
struct Dog
{
    /// <summary>Name of the dog.</summary>
    public string name;
    /// <summary>Age of the dog.</summary>
    public float age;
    /// <summary>Owner of the dog.</summary>
    public string owner;
    /// <summary>Rating of the dog.</summary>
    public Rating rating;

    /// <summary>Creates a new Dog.</summary>
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    /// <summary>Returns the dog's attributes as a string.</summary>
    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating;
    }
}
