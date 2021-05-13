using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_razor_tutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        public void OnGet() // what renders the page
        {
            if (string.IsNullOrEmpty(City))
            {
                City = "The Web";
            }
        }

        // will be run when you post info to the page
        public void OnPost()
        {
            
        }
    }
}
