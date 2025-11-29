using Microsoft.AspNetCore.Mvc;

namespace Lead_Management.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}