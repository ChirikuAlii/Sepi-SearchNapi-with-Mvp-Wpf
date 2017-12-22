using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Presenter.LoginAdmin
{
    interface ILoginAdminPresenter
    {
        void performLogin(String username, String password);
    }
}
