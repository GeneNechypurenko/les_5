using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_5
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("balance can't be negative");
            }

            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("deposit can't be negative");
            }

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("withdraw can't be negative");
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException("insufficient funds");
            }

            balance -= amount;
        }

        public void WithdrawMoney(double amount)
        {
            try
            {
                Withdraw(amount);
                Console.WriteLine($"withdraw {amount}, balance: {GetBalance()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
