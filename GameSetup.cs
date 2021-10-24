using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameSetup
{
	// Number of Players ////////////////////////////////
	public static int playerAmount;
	public static int SetPlayerAmount()
	{
		Console.WriteLine("Welcome to the game. Only 2-8 players can play. Enter the number of players:");

		string playerAmountString = Console.ReadLine();

		while (playerAmountString != "2"
		&& playerAmountString != "3"
		&& playerAmountString != "4"
		&& playerAmountString != "5"
		&& playerAmountString != "6"
		&& playerAmountString != "7"
		&& playerAmountString != "8")
		{
			Console.WriteLine("Error! Please enter a number from 2 to 8:");
			playerAmountString = Console.ReadLine();
		}
		
		return Int32.Parse(playerAmountString);
	}
	
	// List of Players & Their Data /////////////////////
	public static List<Player> NewPlayer = new List<Player>();
	public static void CreatePlayers()
	{
		playerAmount = SetPlayerAmount();
		Console.WriteLine("-----------------------------------------------------\nAdding Players:");

		for (int i = 0; i < playerAmount; i++)
    {
		Console.WriteLine("");

			string number = "Player_" + (i + 1);
      Console.Write($"Player_{i + 1}\nEnter your name: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

			NewPlayer.Add(new Player(number, name, age, 0));
    }

		Console.WriteLine("-----------------------------------------------------\nPlayers:");

    foreach (var player in NewPlayer)
    {
      Console.WriteLine("");
			Console.WriteLine($"Number: {player.Number}\nName: {player.Name}\nAge: {player.Age}\nLuck: {player.Luck}\nPoints: {player.Points}");
    }
	}

	// Testing //////////////////////////////////////////
	public static void DiceTest()
	{
		Console.WriteLine("-----------------------------------------------------\nDice Test:\n \nEach player will automatically roll a 10 sided die and the player(s) with the highest roll will be the winner(s) of the test. No points will be awarded, this is just a test.\n");
		int[] d10Rolls = new int[playerAmount];

		for (int i = 0; i < playerAmount; i++)
    {
      Console.WriteLine($"{NewPlayer[i].Name} rolled a(n) {NewPlayer[i].D10}.");
			d10Rolls[i] = NewPlayer[i].D10;
    }

		int maxValue = d10Rolls.Max();
		// Looping through array of dice rolls to get which player(s) got the highest roll(s)
		for (int i = 0; i < d10Rolls.Length; i++)
		{
			if (d10Rolls[i] == maxValue)
			{
				Console.WriteLine($"{NewPlayer[i].Name} is a winner of the dice roll.");
			}
		}
	}

}