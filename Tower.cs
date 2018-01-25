using System;
namespace TreehouseDefense
{
	class Tower
	{
		protected virtual int Range
		{
			get
			{
				return 1;
			}
		}
		protected virtual int Power
		{
			get
			{
				return 1;

			}
		}
		protected virtual double Accuracy
		{
			get
			{
				return .75;
			}
		}


		private readonly MapLocation _location;
		public bool IsSuccessfulShot()
		{
			return Random.NextDouble() < Accuracy;
		}
		public Tower(MapLocation location)
		{
			_location = location;
		}

		public void FireOnInvaders(IInvader[] invaders)
		{

    		// for (int i = 0; i<invaders.Length;i++)
    		// {
    		// 	Invader invader = invaders[i];
    		// }
			foreach(IInvader invader in invaders)
			{
				if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
				{
					if (IsSuccessfulShot())
					{
						invader.DecreaseHealth(Power);
						Console.WriteLine("shot at and hit");
						if (invader.IsNeutralized)
						{
							Console.WriteLine("neutralized an invader at " + invader.Location +"!");

						}
					}
					else
					{
						Console.WriteLine("missed");
						Console.WriteLine(invader.GetType());

					}
					break;
				}
			}
		}
	}
}