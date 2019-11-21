using System;
using AspProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.Name, "ASP.Net");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.m_customerName,"Mr. Bryan Walton");
        }


        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Tutorial account = new Tutorial("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }


        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            Tutorial account = new Tutorial("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}
