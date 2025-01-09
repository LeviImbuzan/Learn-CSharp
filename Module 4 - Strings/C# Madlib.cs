using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a MadLib...
      Author: Codecademy x Levi x ChatGPT...
      */


      // Let the user know that the program is starting:

      // Give the Mad Lib a title:
      string title = "Fucked Madlib";

      Console.WriteLine($"The program {title} is now running");
      // Define user input and variables:

      Console.Write("Enter a name: ");
      string mainCharacter = Console.ReadLine();

      Console.Write("Enter an adjective (a word that describes a color, feeling or texture): ");
      string adjectiveOne = Console.ReadLine();

      Console.Write("Enter another adjective: ");
      string adjectiveTwo = Console.ReadLine();

      Console.Write("Enter a final adjective: ");
      string adjectiveThree = Console.ReadLine();

      Console.Write("Enter a verb (an action): ");
      string verbOne = Console.ReadLine();

      Console.Write("Enter a noun (person, place, or thing): ");
      string nounOne = Console.ReadLine();

      Console.Write("Enter another noun: ");
      string nounTwo = Console.ReadLine();

      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Enter a food: ");
      string food = Console.ReadLine();

      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();
        
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();

      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Enter a year: ");
      string year= Console.ReadLine();

      // The template for the story:

      string story = $"This morning {mainCharacter} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {mainCharacter} texted {superhero}, who flew {mainCharacter} to {country} and dropped {mainCharacter} in a puddle of frozen {dessert}. {mainCharacter} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

      // Print the story:

      Console.WriteLine(story);

    }
  }
}
