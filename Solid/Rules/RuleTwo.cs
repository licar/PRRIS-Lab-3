using System.Collections.Generic;

namespace Solid.Rules
{
	public class SecondTwo : IRule
	{
		private readonly IList<char> productsNames = new List<char> { 'D', 'E' };
		private const int PERSENT = 5;

		public bool CheckSuit(IBucket bucket)
		{
			return bucket.Contains(productsNames);
		}

		public void Excecute(IBucket bucket)
		{
			bucket.DecreasePrices(productsNames, PERSENT);
		}
	}
}