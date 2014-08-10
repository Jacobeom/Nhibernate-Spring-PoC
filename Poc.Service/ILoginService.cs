using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Service
{
    public  interface ILoginService
    {
        Guid? LogIn(string user, string password);

        void LogOut(Guid session);
    }
}
