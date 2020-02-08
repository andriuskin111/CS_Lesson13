using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagerBusinesLogicLayer
{
    public class Company
    {
        public int CompanyId { get; private set; }
        public string CompanyName { get; private set; }
        public List<string> PhoneNumbers;

        public Company(int companyId, string companyName)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            PhoneNumbers = new List<string>();
        }
    }
}
