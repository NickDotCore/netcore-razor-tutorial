using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netcore_razor_tutorial.Models;

namespace netcore_razor_tutorial.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public Address address { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index", new { City = address.City });
        }
    }
}
