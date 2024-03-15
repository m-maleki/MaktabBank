
using MaktabBank.Core.Core.Interface.AppServices;
using MaktabBank.Core.Core.Interface.Services;
using MaktabBank.Services.Services;

namespace MaktabBank.Services.AppServices
{
    public class BankAccountAppServices : IBankAccountAppServices
    {
        private readonly IBankAccountServices _bankAccountServices;
        private readonly IMessageServices _messageServices;
        private readonly IUserServices _userServices; 

        public BankAccountAppServices(IBankAccountServices bankAccountServices,
            IMessageServices smsServices, IUserServices userServices)
        {
            _bankAccountServices = bankAccountServices;
            _messageServices = smsServices;
            _userServices = userServices;
        }

        public void TransferMoney(string fromCard, string toCard, int money, string password)
        {
            if (!_bankAccountServices.CheckAccountPassword(fromCard, password)) return;

            if (!_bankAccountServices.CheckInventory(fromCard, money)) return;

            if (!_bankAccountServices.CheckCardNumber(toCard)) return;

            if (!_bankAccountServices.CardIsValid(toCard)) return;

            _bankAccountServices.TransferMoney(fromCard,toCard,money);

            var inventory = _bankAccountServices.Inventory(fromCard);

            var message = $"مبلغ {money} از حساب شما کسر شد {Environment.NewLine} " +
                          $"موجودی شما : {inventory}";

            var phoneNumber = _userServices.GetPhoneNumberWithCardNumber(fromCard);
            string emailAddress = string.Empty;

            _messageServices.Send(message, phoneNumber, emailAddress);

            inventory = _bankAccountServices.Inventory(toCard);

            message = $"مبلغ {money} به حساب شما واریز شد {Environment.NewLine} " +
                      $"موجودی شما : {inventory}";

            phoneNumber = _userServices.GetPhoneNumberWithCardNumber(toCard);

            emailAddress = string.Empty;
            _messageServices.Send(message, phoneNumber, emailAddress);
        }

        public void BuyWithPos(int money, string fromCard, int posNumber)
        {
            var toCardNumber = "603799765533";

            _bankAccountServices.TransferMoney(fromCard, toCardNumber, money);

        }

        /// <summary>
        /// هزینه ی خدمات پیامکی
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void CostSms(string cardNumber)
        {
            _bankAccountServices.Withdraw(cardNumber, 10000);
        }
    }
}
