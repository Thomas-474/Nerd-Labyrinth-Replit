using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
  public string Number;
	public string Name;
  public int Age;
  public double Luck = LuckGenerator();
  public double Points;
	public int D10 = Roll();

	public Player(string number, string name, int age, double points)
	{
		this.Number = number;
		this.Name = name;
		this.Age = age;
		this.Points = points;
	}

	public static double LuckGenerator()
  {
		Random random = new Random();
    double luck = random.NextDouble() + 1;
    return luck;
  }

	public static int Roll()
	{
		Random random = new Random();
		int d10 = random.Next(1,10);
		return d10;
	}

}