using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Domain.Concrete
{
	public class ProductRepository : IProductRepository
	{
		private Context context = new Context();
		public IEnumerable<Product> Products {
			get { return context.Products; }
		}
	}
}
