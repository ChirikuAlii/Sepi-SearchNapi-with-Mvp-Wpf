using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginAdmin;
using Sepii.View;

namespace Sepii.Presenter.LoginAdmin
{
    class LoginAdminPresenterImpl : ILoginAdminPresenter , IOnLoginAdminFinishedListener
    {
        //connect with view
       
        ILoginAdminView loginAdminView;
        ILoginAdminInteractor loginAdminInteractor = new LoginAdminInteractorImpl();
        AdminModel adminModel = new AdminModel();

        public LoginAdminPresenterImpl(ILoginAdminView view)
        {
            this.loginAdminView = view;
        }

        public void performLogin(String username, String password)
        {
            loginAdminInteractor.LoginAdmin(username, password, this, adminModel);
        }



        //override
        public void onEmptyUsernameOrPassword()
        {
            loginAdminView.setEmptyUsernameOrPassword();
        }

        public void onSuccess()
        {
            loginAdminView.setLoginSuccess();
        }

        public void onUsernameAndPasswordError()
        {
            loginAdminView.setLoginUsernameOrPasswordError();
        }

        
    }
}
