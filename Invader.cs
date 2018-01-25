using System;
namespace TreehouseDefense
{
	// Invader does not inherit fro IInvader, but it implements IInvader's interface
	abstract class Invader : IInvader
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

		protected virtual int StepSize
		{
			get{
				return 1;
			}
		}
		// (Custom Property)
		public MapLocation Location
		{
			get
			{
				return _path.GetLocationAt(_pathStep);
			}
		}
		public int Health=1;

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
			_pathStep += StepSize;
			// Dont need to update here anymore b/c of custom getter

			// Location = _path.GetLocationAt(_pathStep);
		}

		public virtual void DecreaseHealth(int factor)
		{
			Console.WriteLine(this + ", " + this.Health);
			Health -= factor;
		}
	}
}