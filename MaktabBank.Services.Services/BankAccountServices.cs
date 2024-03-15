using MaktabBank.Core.Core.Interface.Repository;
using MaktabBank.Core.Core.Interface.Services;

namespace MaktabBank.Services.Services
{
    public class BankAccountServices : IBankAccountServices
    {
        private readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountServices(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public bool CheckAccountPassword(string cardNumber, string password)
        { 
            return _bankAccountRepository.CheckAccountPassword(cardNumber, password);
        }

        public bool CheckInventory(string cardNumber, int money)
        {
            return _bankAccountRepository.CheckInventory(cardNumber, money);
        }

        public bool CheckCardNumber(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public bool CardIsValid(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw(string fromCard, int money)
        {
            throw new NotImplementedException();
        }

        public bool Deposit(string ToCard, int money)
        {
            throw new NotImplementedException();
        }

        public void TransferMoney(string fromCard, string toCard, int money)
        {
            _bankAccountRepository.Withdraw(fromCard, money);
            // کم کردن کارمزد
            _bankAccountRepository.Deposit(toCard, money);
        }

        public int Inventory(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
