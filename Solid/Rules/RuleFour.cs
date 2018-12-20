using System.Collections.Generic;

namespace Solid.Rules
{
	public class RuleFour : IRule
	{
		private readonly IList<char> productsNames = new List<char> { 'K', 'L', 'M' };
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