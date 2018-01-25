using System;
namespace TreehouseDefense
{
	class Level
	{
		private readonly IInvader[] _invaders;
		public Tower[] Towers {get;set;}
		public Level(IInvader[] invaders)
		{
			_invaders = invaders;
		}

		//returns true if player wins, false otherwise
		public bool Play()
		{
			//run until invaders neutralized

			int remainingInvaders = _invaders.Length;

			while(remainingInvaders>0)
			{
				//each tower fires on invaders
				foreach(Tower tower in Towers)
				{
					tower.FireOnInvaders(_invaders);
				}

				//count invaders and move them down
				remainingInvaders = 0;
				foreach(IInvader invader in _invaders)
				{
					if(invader.IsActive)
					{
						invader.Move();
						if (invader.HasScored)
						{
							return false;
						}
						remainingInvaders++;
					}

				}
			}


			return true;
		}
	}
}