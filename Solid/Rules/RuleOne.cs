using System.Collections.Generic;

namespace Solid.Rules
{
	public sealed class RuleOne : IRule
	{
		private readonly IList<char> productsNames = new List<char>{'A', 'B'};
		private const int PERSENT = 10;

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