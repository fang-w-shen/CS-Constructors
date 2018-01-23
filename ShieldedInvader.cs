using System;
namespace TreehouseDefense
{
	class ShieldedInvader : Invader
	{
		private static Random _random = new Random();
		public ShieldedInvader(Path path) : base(path)
		{

		}
		public override void DecreaseHealth(int factor)
		{
			if (_random.NextDouble() < .5)
			{
				base.DecreaseHealth(factor);
			}
			else
			{
				System.Console.WriteLine("shotat shielded 0 damage");
			}
		}
	}
}