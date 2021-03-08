using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Examples.Models;
using Razor_Pages_Examples.Services;

namespace Razor_Pages_Examples.Pages.Users
{
    public class SimpleUserModel : PageModel
    {
        [BindProperty]
        public UserEntityModel UserEntityModel { get; set; }

        private UserStorageService _db;

        public SimpleUserModel()
        {
            _db = UserStorageService.GetInstance();
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            
            _db.CreateUser(new UserEntityModel()
            {
                FirstName = UserEntityModel.FirstName,
                LastName = UserEntityModel.LastName
            });
            
            return RedirectToPage("./Users");
        }
    }
}