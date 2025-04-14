// ---------------------------------------------
// EXERCISE 07: Access Modifiers
// Topics: public, private, encapsulation
// ---------------------------------------------

namespace Refresher
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            // TODO: Only allow deposit if amount is positive
        }

        public void Withdraw(decimal amount)
        {
            // TODO: Only allow withdrawal if amount <= _balance
        }

        public void ShowBalance()
        {
            // TODO: Print current balance
        }
    }

    public class Exercise07
    {
        public static void Run()
        {
            Console.WriteLine("== Access Modifiers and Encapsulation ==\n");

            // TODO: Create a BankAccount instance with a starting balance

            // TODO: Try deposit, withdraw, and print balance
        }
    }
}
