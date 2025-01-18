using System;

public class Star
{
    // Fields
    public string name;
    public string type;
    public int age;
    public double brightness;

    // Constructor with parameters to set both 'name' and 'type'
    public Star(string name = "Unknown", string type = "Unknown")
    {
        this.name = name;
        this.type = type;    // Default value for 'type' if not provided
        this.age = 0;        // Default value for 'age'
        this.brightness = 1.0; // Default value for 'brightness'
        Console.WriteLine($"Star created: Name = {this.name}, Type = {this.type}");
    }

    // Method to simulate the star shining
    public void Shine()
    {
        Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
    }

    // Method to simulate the star growing older
    public void GrowOlder()
    {
        this.age++; // Increase the age
        this.brightness *= 0.9; // Decrease brightness by 10%
        Console.WriteLine($"Star {name} has grown older. Age: {age}, Brightness: {brightness}");
    }

    // Method to simulate the star exploding in a supernova
    public void Supernova()
    {
        this.brightness = 0; // The star's brightness becomes 0 after the supernova
        Console.WriteLine($"Star {name} has exploded in a supernova.");
    }
}
