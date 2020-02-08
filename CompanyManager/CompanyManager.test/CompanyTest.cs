using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CompanyManagerBusinesLogicLayer;

namespace CompanyManager.test
{
    [TestClass]
    public class CompanyTest
    {
        [TestMethod]
        public void TestGetPhoneNumbersCount()
        {
            // Arrange
            Company company = new Company(1, "UAB EAMV", false);
            company.PhoneNumbers.Add("86555555");
            company.PhoneNumbers.Add("86222222");
            company.PhoneNumbers.Add("86333333");

            int expected = 3;

            // Act
            int actual = company.PhoneNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
