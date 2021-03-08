using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor_Pages_Examples.Pages.Users
{
    public class UsersModel : PageModel
    {
        private readonly ILogger<UsersModel> _logger;
        
        public UsersModel(ILogger<UsersModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
        }
    }
}