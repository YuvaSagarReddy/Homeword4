using System;
namespace Homework_4
{
	public class orderChecker
	{
		public bool OrderSorted(string test)
		{
			for (int x = 0; x < test.Length - 1; x++)
			{
				if ((int)test[x] > (int)test[x + 1])
				{
					return false;
				}
			}
			return true;
				
		}
	}
}

