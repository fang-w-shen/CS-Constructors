using System;

namespace TreehouseDefense
{
	class Game
	{
		public static void Main()
		{
			Map map = new Map(8, 5);
			try
			{

				MapLocation x = new MapLocation(1,7,map);
			}
			catch(OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);


			}
			catch(TreehouseDefenseException)
			{
				Console.WriteLine("not yet complete");


			}
			catch(Exception)
			{
				Console.WriteLine("unhandled");


			}
		}
	}
}