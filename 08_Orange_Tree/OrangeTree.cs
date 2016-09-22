using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Orange_Tree
{
	class OrangeTree
	{
		public int Age = 0;
		public int Height = 0;
		public int NumOranges = 0;
		public int OrangesEaten = 0;
		public bool TreeAlive = false;

		public OrangeTree(int startage, int startheight)
		{
			Age = startage;
			Height = startheight;
			TreeAlive = true;
		}

		public void OneYearPasses()
		{
			Age++;
			Height += 2;
			if(Age >= 80)
			{
				TreeAlive = false;
				return;
			}
			else if(Age >= 2)
			{
				NumOranges += 5;
			}
		}

		public void EatOrange(int amount)
		{
			if(NumOranges >= amount)
			{
				NumOranges -= amount;
				OrangesEaten += amount;
			}else
			{
				throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
			}
		} 

	}
}
