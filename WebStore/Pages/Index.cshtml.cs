using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        [BindProperty(SupportsGet = true)]
        public String UserName { get; set; }

        public void OnGet()
        {
            if (String.IsNullOrWhiteSpace(UserName))
            {
                UserName = "Please Create Account";

            }

        }
    }
}
