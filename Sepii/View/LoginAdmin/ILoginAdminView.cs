using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.View
{
    interface ILoginAdminView


    {
        void setLoginSuccess();
        void setLoginUsernameOrPasswordError();
        void setEmptyUsernameOrPassword();
    }
}
