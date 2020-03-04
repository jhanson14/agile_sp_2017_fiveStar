using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore
{
	public class DeleteModel : PageModel
	{
		private readonly WebStore.Data.WebStoreContext _context;

		public DeleteModel(WebStore.Data.WebStoreContext context)
		{
			_context = context;
		}

		[BindProperty]
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

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Products = await _context.Products.FindAsync(id);

			if (Products != null)
			{
				_context.Products.Remove(Products);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}
