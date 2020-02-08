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
        public bool NonCommercialOrganisation { get; private set; }
        
        public List<string> PhoneNumbers { get; private set; }

        public Company(int companyId, string companyName, bool nonCommercialOrganisation, List<string> phoneNumbers)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            NonCommercialOrganisation = nonCommercialOrganisation;
            PhoneNumbers = phoneNumbers;
        }

        public int GetPhoneNumbersCount()
        {
            return PhoneNumbers.Count;
        }
    }
}
