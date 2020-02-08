using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagerBusinesLogicLayer
{
    public class CompanyRepository
    {
        private List<Company> _companies;

        public CompanyRepository()
        {
            _companies = new List<Company>
            {
                new Company(1, "UAB Bobutes vainikai", true, new List<string> { "112", "911"}),
                new Company(2, "UAB Dieduko vantos", true, new List<string> { "02", "04"}),
                new Company(3, "UAB EAMV", false, new List<string> { "86666666", "85222222", "90000000"}),
                new Company(4, "UAB Garazas 50", false, new List<string> { "86666666", "85222222"}),
                new Company(5, "UAB Xtra Motorsport", false, new List<string> { "86666666", "85222222"})
            };
        }

        public Company Retrieve(int companyId)
        {
            foreach (var company in _companies)
            {
                if(companyId == company.CompanyId)
                {
                    return company;
                }
            }

            return null;
        }

        public List<Company> Retrieve()
        {
            return _companies;
        }
    }
}
