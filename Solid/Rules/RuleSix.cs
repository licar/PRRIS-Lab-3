namespace Solid.Rules
{
	public class RuleSix : IRule
	{
		private const int PERSENT = 10;

		public bool CheckSuit(IBucket bucket)
		{
			return bucket.GetProducts().Count == 4;
		}

		public void Excecute(IBucket bucket)
		{
			bucket.AddDiscount(PERSENT);
		}
	}
}