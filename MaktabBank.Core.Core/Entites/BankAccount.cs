﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabBank.Core.Core.Entites
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public int Money { get; set; }
        public User User { get; set; }
    }
}
