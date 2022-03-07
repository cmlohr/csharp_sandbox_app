using System;

namespace DiceGame
{
  class Program
  {
    static void Main(string[] args)
    {
      int playerRandomNum;
      int enemyRandomNum;
      Random random = new Random();
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Press any key to roll the dice!");

        Console.ReadKey();
        playerRandomNum = random.Next(1, 7);
        Console.WriteLine("You rolled a " + playerRandomNum);

        Console.WriteLine("...");
        System.Threading.Thread.Sleep(2000);

        enemyRandomNum = random.Next(1, 7);
        Console.WriteLine("AI rolled" + enemyRandomNum);

        if (playerRandomNum > enemyRandomNum)
        {
          playerPoints++;
          Console.WriteLine("You win!");
        }
        else if (playerRandomNum < enemyRandomNum)
        {
          enemyPoints++;
          Console.WriteLine("AI win!");
        }
        else
        {
          Console.WriteLine("Draw");
        }

        Console.WriteLine("Player: " + playerPoints + " | AI: " + enemyPoints);
        Console.WriteLine();
      }

      if (playerPoints > enemyPoints)
      {
        Console.WriteLine("Win!");
      }
      else if (playerPoints < enemyPoints)
      {
        Console.WriteLine("Lose!");
      }
      else
      {
        Console.WriteLine("Draw!");
      }

      Console.ReadKey();
    }
  }
}