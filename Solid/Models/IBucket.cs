using System.Collections.Generic;
using Solid.Models;

namespace Solid
{
	public interface IBucket
	{
		int GetSum();
		IList<Product> GetProducts();
		bool Contains(IList<char> names);
		int GroupsCount(IList<char> names);
		void DecreasePrices(IList<char> names, int persent);
		void AddDiscount(int persent);
	}
}