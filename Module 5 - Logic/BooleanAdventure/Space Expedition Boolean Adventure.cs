using System;

public class SpaceExpedition
{
  public static void Main(string[] args){
    // Your code goes here

    bool isAtmosphereBreathable = true;
    bool isGravityStable = false;
    bool resourcesSufficient = true;

    bool isHabitable = isAtmosphereBreathable && isGravityStable;

    Console.WriteLine("Is this planet habitable? " + isHabitable);

    bool suitableForExpansion = isGravityStable || resourcesSufficient;

    Console.WriteLine("Is this planet suitable for expansion? " + suitableForExpansion);

    int currentCrew = 5;

    int maxCrewCapacity = 10;

    bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;

    Console.WriteLine("Can the current expedition accept more crew members? " + canAcceptMoreCrew);
    



    
  }
}