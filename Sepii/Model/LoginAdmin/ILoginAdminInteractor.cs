using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Model.LoginAdmin
{
    interface ILoginAdminInteractor
    {
        void LoginAdmin(String username, String password, IOnLoginAdminFinishedListener listener ,AdminModel adminModel);

    }

    interface IOnLoginAdminFinishedListener
    {
        void onSuccess();
        void onUsernameAndPasswordError();
        void onEmptyUsernameOrPassword();
        
    }
}
