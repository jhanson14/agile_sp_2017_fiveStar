using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore
{
	public class EditModel : PageModel
	{
		private readonly WebStore.Data.WebStoreContext _context;

		public EditModel(WebStore.Data.WebStoreContext context)
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

		// To protect from overposting attacks, please enable the specific properties you want to bind to, for
		// more details see https://aka.ms/RazorPagesCRUD.
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Attach(Products).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ProductsExists(Products.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return RedirectToPage("./Index");
		}

		private bool ProductsExists(int id)
		{
			return _context.Products.Any(e => e.Id == id);
		}
	}
}
