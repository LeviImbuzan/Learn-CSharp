using System;

namespace SpaceMission
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceInventory = new string[] {"Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools"};

      int[] itemQuantities =  new int[] {10, 8, 15, 5, 6, 9, 4, 7};

      if (spaceInventory.Length == 8){
        Console.WriteLine("Space Inventory is ready to go!");
      }
      else if (spaceInventory.Length < 8){
        Console.WriteLine("Add More Items!");    
      }
      else if (spaceInventory.Length > 8){
        Console.WriteLine("Too Many Items!");
      }
      Console.WriteLine("This item is " + spaceInventory[1] + " and there are " + itemQuantities[1] + " total items.");

      spaceInventory[7] = "Scientific Instruments";
      itemQuantities[7] = 5;

      int index = Array.IndexOf(itemQuantities, 5);
      Console.WriteLine($"The first item with quantity 5 is at position {index}");

      Array.Reverse(spaceInventory);
      Console.WriteLine("The new reversed first item is " + spaceInventory[0] + " and the new reversed last item is " + spaceInventory[7]);

      Array.Sort(spaceInventory);
      Console.WriteLine("When sorted alphabetically, the new first item is " + spaceInventory[0] + " and the new last item is " + spaceInventory[7]);



    }
  }
}