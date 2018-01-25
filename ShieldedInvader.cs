using System;
namespace TreehouseDefense
{
	class ShieldedInvader : Invader
	{
		// private static Random _random = new Random();
		public ShieldedInvader(Path path) : base(path)
		{

		}
		public override void DecreaseHealth(int factor)
		{
			if (Random.NextDouble() < .5)
			{
				base.DecreaseHealth(factor);
			}
			else
			{
				System.Console.WriteLine("hit but took 0 damage");
			}
		}
	}
}