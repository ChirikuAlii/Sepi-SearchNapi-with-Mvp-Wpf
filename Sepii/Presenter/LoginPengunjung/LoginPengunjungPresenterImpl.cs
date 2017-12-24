using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;
using Sepii.View;

namespace Sepii.Presenter.LoginPengunjung
{
    class LoginPengunjungPresenterImpl : ILoginPengunjungPresenter , IOnLoginPengunjungFinishedListener
    {
        
        ILoginPengunjungView loginPengunjungView;
        ILoginPengunjungInteractor loginPengunjungInteractor = new LoginPengunungjungInteractorImpl();
       

        public LoginPengunjungPresenterImpl(ILoginPengunjungView view)
        {
            this.loginPengunjungView = view;
        }


        public void performKirim(String nomorKtpMember, String nomorTahanan)
        {
            loginPengunjungInteractor.LoginPengungjung(nomorKtpMember, nomorTahanan, this);
        }

        public void performSearchIdMember(string nomorKtpMember)
        {
            loginPengunjungInteractor.SearchIdMember(nomorKtpMember,this);
        }

        public void performSearchIdNapi(string nomorTahanan)
        {
            loginPengunjungInteractor.SearchIdNapi(nomorTahanan, this);
        }

        //override
        public void onErrorKirim()
        {
            loginPengunjungView.setAddDataError();
        }

        public void onSuccessKirim()
        {
            loginPengunjungView.setAddDataSuccess();
        }



        public void onErrorCariIdMember()
        {
            loginPengunjungView.setErrorItemMember();
        }


     
        public void onSuccessCariIdMember(MemberModel memberModel)
        {
            
            //binding model ke interface View
            loginPengunjungView.setItemMemberr(memberModel);
            
        }

        public void onSuccessCariIdNapi(NapiModel napiModel)
        {
            //bindng model ke interface View
            loginPengunjungView.setItemNapi(napiModel);
        }

        public void onErrorCariIdNapi()
        {
            loginPengunjungView.setErrorItemNapi();
        }

       
    }
}
