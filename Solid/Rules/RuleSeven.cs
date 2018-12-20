namespace Solid.Rules
{
	public class RuleSeven : IRule
	{
		private const int PERSENT = 20;

		public bool CheckSuit(IBucket bucket)
		{
			return bucket.GetProducts().Count == 5;
		}

		public void Excecute(IBucket bucket)
		{
			bucket.AddDiscount(PERSENT);
		}
	}
}