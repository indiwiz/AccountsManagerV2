using Microsoft.AspNetCore.Mvc;

namespace AccountsManager.Web.Controllers
{
    public class CompaniesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }
    }
}