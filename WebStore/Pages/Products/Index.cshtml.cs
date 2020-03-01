using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebStore.Data;
using WebStore.Models;

namespace WebStore
{
    public class IndexModel : PageModel
    {
        private readonly WebStore.Data.WebStoreContext db;

        public IndexModel(WebStoreContext db) => this.db = db;
        public List<Products> Products { get; set; } = new List<Products>();

        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();

        }
    }
}
