using System;
namespace TreehouseDefense
{
	class Path
	{
		private readonly MapLocation[] _path;
		public Path(MapLocation[] path)
		{
			_path = path;
			Console.WriteLine("Path created");
		}
		public int Length
		{
			get{

				return _path.Length;
			}
		}
		public MapLocation GetLocationAt(int pathStep)
		{
			return (pathStep < _path.Length) ? _path[pathStep] : null;
		}
	}
}