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
        List<MemberModel> memberModelList = new List<MemberModel>();
        List<NapiModel> napiModelList = new List<NapiModel>();

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
            loginPengunjungInteractor.SearchIdMember(nomorKtpMember,this , memberModelList);
        }

        public void performSearchIdNapi(string nomorTahanan)
        {
            loginPengunjungInteractor.SearchIdNapi(nomorTahanan, this, napiModelList);
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


     
        public void onSuccessCariIdMember()
        {
            
            //binding model ke interface View
            loginPengunjungView.setItemMemberr(memberModelList);
            
        }

        public void onSuccessCariIdNapi()
        {
            //bindng model ke interface View
            loginPengunjungView.setItemNapi(napiModelList);
        }

        public void onErrorCariIdNapi()
        {
            loginPengunjungView.setErrorItemNapi();
        }

       
    }
}
