using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
//switched ecimal to int!!
namespace BankTellerExercise.Tests
{
    [TestClass]
    public class CheckingAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType("BankTellerExercise.CheckingAccount, BankTellerExercise");
            properties = type.GetProperties();
        }

        [TestMethod]
        public void WithdrawNegativeWithFeeBalanceTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -1);

            decimal newBalance = chkAccount.Withdraw(1);

            Assert.AreEqual(newBalance, -12);
            Assert.AreEqual(chkAccount.Balance, -12);
        }

        [TestMethod]
        public void WithdrawPositiveWithFeeTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -1);

            decimal newBalance = chkAccount.Withdraw(2);

            Assert.AreEqual(newBalance, -13);
            Assert.AreEqual(chkAccount.Balance, -13);
        }

        [TestMethod]
        public void WithdrawNegativeBalanceBelow100Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -100);

            decimal newBalance = chkAccount.Withdraw(2);

            Assert.AreEqual(newBalance, -100);
            Assert.AreEqual(chkAccount.Balance, -100);
        }

        [TestMethod]
        public void WithdrawPositiveBalanceTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", 10);

            decimal newBalance = chkAccount.Withdraw(5);

            Assert.AreEqual(newBalance, 5);
            Assert.AreEqual(chkAccount.Balance, 5);
        }

        [TestMethod]
        public void TransferTest()
        {
            CheckingAccount source = new CheckingAccount("", "", 50);
            CheckingAccount destination = new CheckingAccount("", "");

            MethodInfo method = type.GetMethod("TransferTo");

            object[] methodParameters = new object[] { destination, 24 };

            method.Invoke(source, methodParameters);

            object newSourceBalance = GetPropertyValue(source, "Balance");

            Assert.AreEqual(26, newSourceBalance);
            Assert.AreEqual(24, destination.Balance);
            Assert.AreEqual(26, source.Balance);
        }

        private object GetPropertyValue(object instance, string propName)
        {
            object retVal = new object();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name == propName)
                {
                    retVal = prop.GetValue(instance);
                }
            }
            return retVal;
        }
    }
}
