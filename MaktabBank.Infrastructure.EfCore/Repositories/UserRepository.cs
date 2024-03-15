using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaktabBank.Core.Core.Interface.Repository;

namespace MaktabBank.Infrastructure.EfCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        public string GetPhoneNumberWithCardNumber(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
