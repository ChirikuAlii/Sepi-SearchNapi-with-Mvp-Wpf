using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Presenter;

namespace Sepii.Model.LoginPengunjung
{
    interface ILoginPengunjungInteractor 
    {
        void LoginPengungjung(String nomorKtp, String nomorTahanan, IOnLoginPengunjungFinishedListener listener);
        void SearchIdMember(String nomorKtp, IOnLoginPengunjungFinishedListener listener );
        void SearchIdNapi(String nomorTahanan, IOnLoginPengunjungFinishedListener listener);
       
    }

    interface IOnLoginPengunjungFinishedListener
    {
      
        void onSuccessCariIdMember(MemberModel memberModel);
        void onErrorCariIdMember();
        void onSuccessCariIdNapi(NapiModel napiModel);
        void onErrorCariIdNapi();
        void onSuccessKirim();
        void onErrorKirim();
    }
}
