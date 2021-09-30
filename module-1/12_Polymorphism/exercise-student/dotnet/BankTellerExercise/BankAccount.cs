namespace BankTellerExercise
{
    public class BankAccount : IAccountable //switching decimal to int bc int was working and decimal was not
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public int Balance { get; private set; }

        public BankAccount(string accountHolder, string accountNumber)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount(string accountHolder, string accountNumber, int balance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int Deposit(int amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual int Withdraw(int amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
        public virtual int TransferTo(BankAccount destinationAccount, int transferAmount)
        {
            Withdraw(transferAmount);
            destinationAccount.Balance += transferAmount;
            return Balance;
        }
    }
}
