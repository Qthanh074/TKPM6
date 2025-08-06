using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TKPM.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<dynamic>
            {
                new { Id = "DH001", Customer = "Nguyễn Văn A", Total = 500000, Status = "Đang xử lý" },
                new { Id = "DH002", Customer = "Trần Thị B", Total = 750000, Status = "Hoàn tất" }
            };
            return View(orders);
        }
    }
}
