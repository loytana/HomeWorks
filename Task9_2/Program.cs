namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account1 = new BankAccount();
                BankAccount account2 = new BankAccount();

                account1.Deposit(1000);
                Console.WriteLine($"После пополнения: {account1.Balance}");

                account1.Withdraw(300);
                Console.WriteLine($"После снятия: {account1.Balance}");

                account1.Withdraw(800);
                                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Всего счетов: {BankAccount.TotalAccounts}");
            }
        }
    }
    public class BankAccount
    {
        private decimal _balance;

        public static int TotalAccounts = 0;

        public readonly int AccountNumber;
        public decimal Balance
        {
            get => _balance;
            private set
            {
                _balance = value;
            }
        }

        public BankAccount()
        {
            _balance = 0;
            AccountNumber = new Random().Next(1000, 10000);
            TotalAccounts++;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
                throw new ArgumentException("Недостаточно средств на счете");

            Balance -= amount;
        }
    }
}
