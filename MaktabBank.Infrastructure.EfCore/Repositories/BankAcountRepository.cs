using MaktabBank.Core.Core.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Infrastructure.EfCore.Repositories
{
    
    public class BankAcountRepository : IBankAccountRepository
    {
        private readonly AppDbContext _context;

        public BankAcountRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CheckAccountPassword(string cardNumber, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckInventory(string cardNumber, int money)
        {
            throw new NotImplementedException();
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

        public int Inventory(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
