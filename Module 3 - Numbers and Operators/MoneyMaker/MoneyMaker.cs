using MoneyMaker;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Enter an amount to convert to coins: ");
      
      // Get user input and round to the nearest whole cent
      string totalAsString = Console.ReadLine();
      double totalAsDouble = Math.Round(Convert.ToDouble(totalAsString), MidpointRounding.AwayFromZero);

      Console.WriteLine($"{totalAsDouble} cents is equal to... ");

      // Define coin values
      int goldCoin = 10;
      int silverCoin = 5;

      // Calculate gold coins
      int goldCoins = (int)Math.Floor(totalAsDouble / goldCoin);
      double remainder = totalAsDouble % goldCoin;

      // Calculate silver coins
      int silverCoins = (int)Math.Floor(remainder / silverCoin);
      remainder = remainder % silverCoin;

      // Output the result
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}
