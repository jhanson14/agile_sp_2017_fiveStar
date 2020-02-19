using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
	public class Products
	{
		private WebStoreDBContext context;
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
		public string Genre { get; set; }
		public string FilePath { get; set; }
	}
}
