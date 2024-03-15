namespace MaktabBank.Core.Core.Interface.Repository
{
    public interface IBankAccountRepository
    {
        public bool CheckAccountPassword(string cardNumber, string password);
        public bool CheckInventory(string cardNumber, int money);
        public bool CheckCardNumber(string cardNumber);
        public bool CardIsValid(string cardNumber);
        public bool Withdraw(string fromCard, int money); //برداشت به حساب
        public bool  Deposit(string ToCard, int money);  // واریز به حساب
        public int Inventory(string cardNumber);
    }
}
