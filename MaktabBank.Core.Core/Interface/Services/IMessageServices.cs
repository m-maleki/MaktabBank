using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Core.Core.Interface.Services
{
    public interface IMessageServices
    {
        public void Send(string message, string phoneNumber, string emailAddress);
    }
}
