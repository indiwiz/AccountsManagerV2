using Microsoft.AspNetCore.Mvc;
using AccountsManager.Web.Models;
namespace AccountsManager.Web.Controllers
{
    public class CompaniesController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpGet]
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyRegistationModel company)
        {         
            if(!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }

    }
}