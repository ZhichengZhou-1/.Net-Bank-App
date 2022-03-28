using BankyStuff;
using Xunit;
using System;


namespace BankingTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);

        }
        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Kendra", 10000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(7500, DateTime.Now, "Overdraw")
            );
            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Overdraw");
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
                // no need for console statements since Unit test returns error messages 
           // }
            //     account.MakeDeposit(-300, DateTime.Now, "stealing");
        }

        [Fact]
        public void Test3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", -55)
            );
        }
    }
}