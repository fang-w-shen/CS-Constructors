using System;

namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
        	Console.WriteLine("location made from point");
        	if (!map.OnMap(this))
        	{
        		throw new OutOfBoundsException(x +"," + y+" is not on the map!");
        	}

        }
    }
}