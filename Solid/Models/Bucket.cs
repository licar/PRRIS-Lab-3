using System.Collections.Generic;
using System.Linq;
using Solid.Extensions;

namespace Solid.Models
{
	public class Bucket : IBucket
	{
		private readonly IList<Product> products;
		private readonly Dictionary<char, IList<Product>> productsDictionary;
		private readonly IList<int> discounts = new List<int>();

		public int GetSum()
		{
			var sum =  products.Sum(p => p.Price) ;
			return sum - discounts.Sum(d => sum * d / 100);
		}

		public Bucket(IList<Product> products)
		{
			this.products = products;
			foreach (var product in products)
			{
				if (!productsDictionary.ContainsKey(product.Name))
				{
					productsDictionary.Add(product.Name, new List<Product>());
				}
				productsDictionary[product.Name].Add(product);
			}
		}
		
		public IList<Product> GetProducts()
		{
			return products;
		}

		public bool Contains(IList<char> names)
		{
			return names.All(n => productsDictionary.ContainsKey(n));
		}

		public int GroupsCount(IList<char> names)
		{
			return names.Min(n => productsDictionary.TryGetValue(n, out var p) ? p.Count : 0);
		}

		public void DecreasePrices(IList<char> names, int persent)
		{
			var count = GroupsCount(names);
			if (count == 0) return;
		
			names.ForEach(name => productsDictionary[name].Take(count).
				ForEach(product => DecreaseProductPrice(product, persent)));
		}

		public void AddDiscount(int persent)
		{
			discounts.Add(persent);
		}

		private void DecreaseProductPrice(Product product, int persent)
		{
			product.Price -= product.Price * persent / 100;
		}
	}
}