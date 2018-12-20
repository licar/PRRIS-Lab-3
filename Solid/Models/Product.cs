using System.Collections.Generic;

namespace Solid.Models
{
	public class Product
	{
		public int Price { get; set; }
		public char Name { get; set; }
		public IList<int> Discounts { get; set; } = new List<int>();

		public int DiscountedPrice()
		{

		}
	}
}