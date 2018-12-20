namespace Solid.Rules
{
	public interface IRule
	{
		bool CheckSuit(IBucket bucket);
		void Excecute(IBucket bucket);
	}
}