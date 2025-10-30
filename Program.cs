using System;

namespace CIS207.Project6BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bank Account ===");

            BankAccount account1;
            BankAccount account2;

            try
            {
                account1 = new BankAccount("savings account", 100);
                account2 = new BankAccount("spending account", 500);

                account1.PrintSummary();
                account2.PrintSummary();

                try
                {
                    account1.Deposit(30);
                    account2.Deposit(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    account1.Withdraw(5);
                    account2.Withdraw(80);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                account1.PrintSummary();
            }
            catch
            {

            }

        }
    }
}
