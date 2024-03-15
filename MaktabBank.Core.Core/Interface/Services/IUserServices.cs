using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Core.Core.Interface.Services
{
    public interface IUserServices
    {
        public string GetPhoneNumberWithCardNumber(string cardNumber);
    }
}
