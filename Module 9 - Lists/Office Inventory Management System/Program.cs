using System;
using System.Collections.Generic;


public class InventoryManagement
{
  public static void Main(string[] args){
    // Your code goes here
    List<string> inventoryList = new List<string>();
    inventoryList.AddRange(new[] {"Printer", "Laptop", "Desk Chair", "Monitor", "Keyboard"});

    double count = inventoryList.Count;

    Console.WriteLine($"There are a total of {count} items in this list.");
    
    bool hasDeskChair = inventoryList.Contains("Desk Chair");
    Console.WriteLine($"Is there a Desk Chair in this list? {hasDeskChair}");

    bool removed = inventoryList.Remove("Printer");
    Console.WriteLine($"Has Printer been removed from the list? {removed}");

    foreach (string item in inventoryList){
    Console.WriteLine("This item is currently in the list: " + item);
    }

    List<string> newItems = new List<string> {"Mouse", "Desk Lamp"};
    inventoryList.AddRange(newItems);

    inventoryList.RemoveRange(4, 2);
    //Console.WriteLine(inventoryList.Count);

    List<string> topInventory = inventoryList.GetRange(0,3);

    foreach (string item in topInventory) {
      Console.WriteLine("One of the top items is: " + item);
    }
  }
}