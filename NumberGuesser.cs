using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberGuesser
{
	public NumberGuesser()
	{
		Console.WriteLine("-----------------------------------------------------\nNumber Guessing Game:\n ");
		Console.WriteLine("Guess a number from 1 to 10. The number resets for each player.\n");

		for (int i = 0; i < GameSetup.playerAmount; i++)
		{
			Random random = new Random();
			int randomNumber = random.Next(1, 10);

			Console.WriteLine($"It is {GameSetup.NewPlayer[i].Name}'s turn. Guess a whole number from 1 to 10.");
			int guessedNumber = Int32.Parse(Console.ReadLine());

			if (guessedNumber == randomNumber)
			{
				Console.WriteLine("You guessed right! You get 1 point");
				GameSetup.NewPlayer[i].Points = GameSetup.NewPlayer[i].Points + 1;
			}
			else
			{
				Console.WriteLine($"You guessed wrong. The right answere was \"{randomNumber}\". You lose 1 point");
				GameSetup.NewPlayer[i].Points = GameSetup.NewPlayer[i].Points - 1;
			}

			Console.WriteLine("");
		}

		Console.WriteLine("-----------------------------------------------------\nPlayers:\n ");

		foreach (var player in GameSetup.NewPlayer)
    {
      Console.WriteLine("");
			Console.WriteLine($"Number: {player.Number}\nName: {player.Name}\nAge: {player.Age}\nLuck: {player.Luck}\nPoints: {player.Points}");
    }
	}

}