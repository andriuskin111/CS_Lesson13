using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CompanyManagerBusinesLogicLayer;

namespace CompanyManager.test
{
    [TestClass]
    public class CompanyRepositoryTest
    {
        [TestMethod]
        public void TestRetrieveWithCompanyId()
        {
            // Arrange
            CompanyRepository companyRepository = new CompanyRepository();
            Company company = companyRepository.Retrieve(3);
            string expected = "UAB EAMV";

            // Act
            string actual = company.CompanyName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRetrieve()
        {
            // Arrange
            CompanyRepository companyRepository = new CompanyRepository();
            List<Company> companies = companyRepository.Retrieve();
            int expected = 5;

            // Act
            int actual = companies.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
