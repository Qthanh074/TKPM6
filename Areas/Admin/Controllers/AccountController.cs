using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TKPM.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {
        public IActionResult Manage()
        {
            var users = new List<dynamic>
            {
                new { Id = 1, UserName = "admin", Role = "Admin" },
                new { Id = 2, UserName = "user1", Role = "User" }
            };

            return View(users);
        }
    }
}
