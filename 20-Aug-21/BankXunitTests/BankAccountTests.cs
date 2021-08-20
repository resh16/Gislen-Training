using Bank;
using System;
using Xunit;

namespace BankXunitTests
{
    public class BankAccountTests
    {
        [Fact]
        public void Adding_Funds_Updates_Balance()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT
            account.Add(100);

            // ASSERT
            Assert.Equal(1100, account.Balance);
        }

       
    }
}
