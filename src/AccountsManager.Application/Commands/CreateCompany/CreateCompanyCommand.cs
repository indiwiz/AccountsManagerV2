using System;

namespace AccountsManager.Application.Commands.CreateCompany
{
    public class CreateCompanyCommand
    {
        public CreateCompanyCommand(string companyName)
        {
            CompanyName = companyName;            
        }
        public string CompanyName { get; }
    }
}