using System;
namespace TreehouseDefense
{
    class Tower
    {
    	private const int _range = 1;
    	private const int _power = 1;
    	private const double _accuracy = .75;

    	private static readonly Random _random = new Random();
    	private readonly MapLocation _location;
    	public bool IsSuccessfulShot()
    	{
    		return _random.NextDouble() < _accuracy;
    	}
    	public Tower(MapLocation location)
    	{
    		_location = location;
    	}

    	public void FireOnInvaders(Invader[] invaders)
    	{

    		// for (int i = 0; i<invaders.Length;i++)
    		// {
    		// 	Invader invader = invaders[i];
    		// }
    		foreach(Invader invader in invaders)
    		{
    			if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
    			{
    				if (IsSuccessfulShot())
    				{
    					invader.DecreaseHealth(_power);
    					Console.WriteLine("shot at and hit");
    					if (invader.IsNeutralized)
    					{
    						Console.WriteLine("neutralized!");

    					}
    				}
    				else
    				{
    					Console.WriteLine("missed");

    				}
    				break;
    			}
    		}
    	}
    }
}