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
        void SearchIdMember(String nomorKtp, IOnLoginPengunjungFinishedListener listener ,List<MemberModel> memberModel);
        void SearchIdNapi(String nomorTahanan, IOnLoginPengunjungFinishedListener listener, List<NapiModel> napiModel);
       
    }

    interface IOnLoginPengunjungFinishedListener
    {
      
        void onSuccessCariIdMember();
        void onErrorCariIdMember();
        void onSuccessCariIdNapi();
        void onErrorCariIdNapi();
        void onSuccessKirim();
        void onErrorKirim();
    }
}
