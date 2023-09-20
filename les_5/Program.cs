using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account = new BankAccount(1000);
                Console.WriteLine($"Balance: {account.GetBalance()}");

                account.WithdrawMoney(500);
                account.WithdrawMoney(-500);
                account.WithdrawMoney(2000);

                account.Deposit(200);
                Console.WriteLine($"Balance: {account.GetBalance()}");
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
