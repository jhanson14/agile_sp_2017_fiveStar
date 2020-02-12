using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStore.Models;

namespace WebStore.Pages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty]
        public AccountModel Account { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            // Save Account info to database


            return RedirectToPage("/Index", new { Account.UserName });
        }
    }
}
