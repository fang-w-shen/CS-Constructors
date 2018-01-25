using System;
namespace TreehouseDefense
{
	class SniperTower : Tower
	{
		protected override int Range
		{
			get
			{
				return 2;
			}
		}
		protected override double Accuracy
		{
			get
			{
				return 1.0;
			}
		}
		public SniperTower(MapLocation location) : base(location)
		{

		}
	}
}