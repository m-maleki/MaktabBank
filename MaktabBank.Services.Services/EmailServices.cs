using MaktabBank.Core.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Services.Services
{
    public class EmailServices : IMessageServices
    {
        public void Send(string message, string phoneNumber, string emailAddress)
        {
            // send email
        }
    }
}
