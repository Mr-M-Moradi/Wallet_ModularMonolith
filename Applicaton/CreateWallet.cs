using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateWallet
    {
        public bool Create(Guid userID, decimal initialBalance)
        {
            CreateNewWallet(userID, initialBalance);
        }
    }
}

