using System;

namespace TreehouseDefense
{
	class Game
	{
		public static void Main()
		{
			Map map = new Map(8,5) ;
			// int area = map.Width*map.Height;

			try
			{
				Path path = new Path(
					new[] {
						new MapLocation(0,2,map),
						new MapLocation(1,2,map),
						new MapLocation(2,2,map),
						new MapLocation(3,2,map),
						new MapLocation(4,2,map),
						new MapLocation(5,2,map),
						new MapLocation(6,2,map),
						new MapLocation(7,2,map)
					});
				Invader invader = new Invader(path);
				MapLocation location = new MapLocation(0,0,map);
				// Can't set location because it's private
				// invader.Location = location;
				location = invader.Location;

				// Testing path inheritance
				// MapLocation location = path.GetLocationAt(1);
				// if (location != null)
				// {

				// 	Console.WriteLine(location.X + "," +location.Y);
				// }

			}
			catch(OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);


			}
			catch(TreehouseDefenseException)
			{
				Console.WriteLine("not yet complete");


			}

			catch(Exception ex)
			{
				Console.WriteLine("unhandled " + ex);


			}
		}
	}
}