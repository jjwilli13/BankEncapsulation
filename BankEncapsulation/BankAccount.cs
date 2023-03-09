using System;
namespace BankEncapsulation
{
    public class BankAccount
    {

        public BankAccount()
        {

        }

        private double balance = 0;

    
        public void Deposit(double DepositAmount)
        {
            balance = DepositAmount;
        }

        public double GetBalance()
        {
            return balance;
        }


        
    }
}

