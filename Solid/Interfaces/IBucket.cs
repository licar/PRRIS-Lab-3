using System.Collections.Generic;
using Solid.Models;

namespace Solid
{
	public interface IBucket
	{
		IList<Product> GetProducts();
		bool Contains(IList<char> names);
		int GroupsCount(IList<char> names);
	}
}