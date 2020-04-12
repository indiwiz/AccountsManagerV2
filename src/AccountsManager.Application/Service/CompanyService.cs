using System;
using System.Collections.Generic;

namespace AccountsManager.Application.Service
{
    public interface ICompanyService
    {
        void Create(string companyName);
        bool Exists(string companyName);
        List<string> GetAll();
    }

    public class CompanyService : ICompanyService
    {
        private readonly List<string> _companies = new List<string>();

        public void Create(string companyName)
        {
            _companies.Add(companyName);
        }

        public bool Exists(string companyName)
        {
            return _companies.Contains(companyName);
        }

        public List<string> GetAll()
        {
            return _companies;
        }
    }
}