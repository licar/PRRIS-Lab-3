using System.Collections.Generic;
using Solid.Models;

namespace Solid.Factories
{
	public interface IProductsFactory
	{
		IList<Product> GetProducts();
	}
}