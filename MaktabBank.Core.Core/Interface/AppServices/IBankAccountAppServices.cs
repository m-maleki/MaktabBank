using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Core.Core.Interface.AppServices
{
    public interface IBankAccountAppServices
    {
        public void TransferMoney(string fromCard, string toCard, int money , string password);
        public void BuyWithPos(int money, string fromCard, int posNumber);
        public void CostSms(string cardNumber);
    }
}
