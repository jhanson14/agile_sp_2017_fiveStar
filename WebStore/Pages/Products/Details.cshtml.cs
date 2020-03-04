using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore
{
	public class DetailsModel : PageModel
	{
		private readonly WebStore.Data.WebStoreContext _context;

		public DetailsModel(WebStore.Data.WebStoreContext context)
		{
			_context = context;
		}

		public Products Products { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

			if (Products == null)
			{
				return NotFound();
			}
			return Page();
		}
	}
}
