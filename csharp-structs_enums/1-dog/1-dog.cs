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
}
