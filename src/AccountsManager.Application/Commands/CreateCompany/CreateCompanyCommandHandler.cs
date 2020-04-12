using AccountsManager.Application.Service;

namespace AccountsManager.Application.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler : ICommand<CreateCompanyCommand>
    {
        private readonly ICompanyService _companyService;
        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public void Handle(CreateCompanyCommand command)
        {
            _companyService.Create(command.CompanyName);
        }
    }
}