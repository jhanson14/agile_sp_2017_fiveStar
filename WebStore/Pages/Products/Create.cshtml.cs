using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore
{
	public class CreateModel : PageModel
	{
		private readonly WebStore.Data.WebStoreContext _context;

		public CreateModel(WebStore.Data.WebStoreContext context)
		{
			_context = context;
		}

		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public Products Products { get; set; }

		// To protect from overposting attacks, please enable the specific properties you want to bind to, for
		// more details see https://aka.ms/RazorPagesCRUD.
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Products.Add(Products);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
