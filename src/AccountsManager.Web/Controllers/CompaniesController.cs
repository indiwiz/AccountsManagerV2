using Microsoft.AspNetCore.Mvc;
using AccountsManager.Web.Models;
using AccountsManager.Application.Commands;
using AccountsManager.Application.Commands.CreateCompany;
using System.Threading.Tasks;
using System;

namespace AccountsManager.Web.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICommand<CreateCompanyCommand> _createCompanyCommandHandler;
        public CompaniesController(ICommand<CreateCompanyCommand> createCompanyCommandHandler)
        {
            _createCompanyCommandHandler = createCompanyCommandHandler;
        }

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
            var command = ConvertToCommand(company);
            _createCompanyCommandHandler.Handle(command);

            return Redirect("Index");
        }

        private CreateCompanyCommand ConvertToCommand(CompanyRegistationModel model)
        {
            return new CreateCompanyCommand(model.CompanyName);
        }

    }
}