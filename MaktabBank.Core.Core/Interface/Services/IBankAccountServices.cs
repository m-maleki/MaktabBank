using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Core.Core.Interface.Services
{
    public interface IBankAccountServices
    {
        public bool CheckAccountPassword(string cardNumber, string password);
        public bool CheckInventory(string cardNumber, int money);
        public bool CheckCardNumber(string cardNumber);
        public bool CardIsValid(string cardNumber);
        public bool Withdraw(string fromCard, int money); //برداشت به حساب
        public bool Deposit(string ToCard, int money);  // واریز به حساب
        public void TransferMoney(string fromCard, string toCard, int money);
        public int Inventory(string cardNumber);
    }
}
