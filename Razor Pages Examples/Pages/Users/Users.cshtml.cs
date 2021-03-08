using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor_Pages_Examples.Models;
using Razor_Pages_Examples.Services;

namespace Razor_Pages_Examples.Pages.Users
{
    public class UsersModel : PageModel
    {
        public List<UserEntityModel> Users = new List<UserEntityModel>();
        
        private readonly ILogger<UsersModel> _logger;
        private UserStorageService _db;
        
        public UsersModel(ILogger<UsersModel> logger)
        {
            _logger = logger;
            _db = UserStorageService.GetInstance();
        }
        
        public void OnGet()
        {
            Users = _db.GetUsers();
        }
    }
}