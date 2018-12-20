using System.Collections.Generic;

namespace Solid.Rules
{
	public class RuleFive : IRule
	{
		private const int PERSENT = 5;

		public bool CheckSuit(IBucket bucket)
		{
			return bucket.GetProducts().Count == 3;
		}

		public void Excecute(IBucket bucket)
		{
			bucket.AddDiscount(PERSENT);
		}
	}
}