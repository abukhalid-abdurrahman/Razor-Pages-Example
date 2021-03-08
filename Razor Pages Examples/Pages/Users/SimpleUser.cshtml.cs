using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Examples.Models;

namespace Razor_Pages_Examples.Pages.Users
{
    public class SimpleUserModel : PageModel
    {
        [BindProperty]
        public UserEntityModel UserEntityModel { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("./Users");
        }
    }
}