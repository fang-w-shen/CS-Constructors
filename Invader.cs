using System;
namespace TreehouseDefense
{
	class Invader
	{
		// private MapLocation _location;
    	// (Methods) Way of Getting and Setting
		// public MapLocation GetLocation()
		// {
		// 	return _location;
		// }
		// public void SetLocation(MapLocation value)
		// {
		// 	_location = value;
		// }
    	// (Encapsulation) Properties Way of Getting and Setting
		// public MapLocation Location
		// {
		// 	get
		// 	{
		// 		Console.WriteLine("Got from here");
		// 		return _location;
		// 	}
		// 	private set
		// 	{
		// 		Console.WriteLine("Set from here");
		// 		_location = value;
		// 	}
		// }
		//
		//
		//
		// (Auto-Property)
		// public MapLocation Location{get;private set;}
		//


		private readonly Path _path;
		private int _pathStep = 0;

		// (Custom Property)
		public MapLocation Location
		{
			get
			{
				return _path.GetLocationAt(_pathStep);
			}
		}
		public int Health=2;

		public bool HasScored
		{
			get
			{
				return _pathStep>=_path.Length;
			}

		}
		public bool IsNeutralized
		{
			get
			{
				return Health <=0;
			}
		}
		public bool IsActive
		{
			get{
				return !(IsNeutralized || HasScored);
			}
		}
		public Invader(Path path)
		{
			_path = path;

			// Dont need to update here anymore b/c of custom getter
			// Location = _path.GetLocationAt(_pathStep);
		}
		public void Move()
		{
			_pathStep += 1;
			// Dont need to update here anymore b/c of custom getter

			// Location = _path.GetLocationAt(_pathStep);
		}

		public void DecreaseHealth(int factor)
		{
			Health -= factor;
		}
	}
}