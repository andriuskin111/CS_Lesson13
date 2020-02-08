using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagerBusinesLogicLayer;

namespace CompanyManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company(1, "UAB EAMV");
            company.PhoneNumbers.Add("86555555");
            company.PhoneNumbers.Add("86222222");
            company.PhoneNumbers.Add("86333333");

            Console.Write($"Company Id: {company.CompanyId}, " +
                $"Name: {company.CompanyName}");

            foreach (var number in company.PhoneNumbers)
            {
                Console.Write($", {number}");
            }

            Console.ReadLine();
        }
    }
}
