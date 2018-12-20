using System.Collections.Generic;

namespace Solid.Rules
{
	public sealed class RuleThree : IRule
	{
		private readonly IList<char> productsNames = new List<char> { 'E', 'F', 'G' };
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