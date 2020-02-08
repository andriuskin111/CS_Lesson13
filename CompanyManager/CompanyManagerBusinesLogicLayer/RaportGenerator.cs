using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagerBusinesLogicLayer
{
    public class RaportGenerator
    {
        private CompanyRepository _companyRepository;

        public RaportGenerator(CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public string GenerateCompaniesRaport()
        {
            List<Company> companies = _companyRepository.Retrieve();
            string result = "";

            foreach (Company company in companies)
            {
                result += "Company Id: " + company.CompanyId + ", Name: " + company.CompanyName +
                    ", NCO = " + company.NonCommercialOrganisation +
                    ", Phone Numbers(" + company.PhoneNumbers.Count + "): ";

                foreach (var number in company.PhoneNumbers)
                {
                    result += number + "; ";
                }

                result += Environment.NewLine;
            }

            return result;
        }
    }
}
