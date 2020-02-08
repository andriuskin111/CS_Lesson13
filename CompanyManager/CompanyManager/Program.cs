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
            Company company = new Company(1, "UAB EAMV", false, new List<string> { "86555555", "86222222" });
 
            Console.Write($"Company Id: {company.CompanyId}, " +
                $"Name: {company.CompanyName}, Phone Numbers ({company.PhoneNumbers.Count})");

            foreach (var number in company.PhoneNumbers)
            {
                Console.Write($", {number}");
            }

            Console.WriteLine("\n");

            CompanyRepository companyRepository = new CompanyRepository();
            RaportGenerator raportGenerator = new RaportGenerator(companyRepository);
            List<Company> companies = companyRepository.Retrieve();

            ShowCompanies(companies);
            ShowCompanies(companyRepository.Retrieve(3));

            Console.WriteLine(raportGenerator.GenerateCompaniesRaport());

            Console.ReadLine();
        }

        static void ShowCompanies(Company company)
        {
            Console.Write($"Company selected Id: {company.CompanyId}, Name: {company.CompanyName}, " +
                $"NCO = {company.NonCommercialOrganisation}, Phone Numbers({company.PhoneNumbers.Count}): ");

            foreach (var number in company.PhoneNumbers)
            {
                Console.Write($"{number}; ");
            }

            Console.WriteLine("\n");
        }
        static void ShowCompanies(List<Company> companies)
        {
            foreach (var company in companies)
            {
                Console.Write($"Company Id: {company.CompanyId}, Name: {company.CompanyName}, " +
                    $"NCO = {company.NonCommercialOrganisation}, Phone Numbers({company.PhoneNumbers.Count}): ");

                foreach (var number in company.PhoneNumbers)
                {
                    Console.Write($"{number}; ");
                }

                Console.WriteLine();
            }
        }
    }
}
