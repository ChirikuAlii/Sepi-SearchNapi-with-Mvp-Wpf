using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model;

namespace Sepii.Presenter.LoginPengunjung
{
    interface ILoginPengunjungPresenter
    {

        void performKirim(String nomorKtpMember ,String nomorTahanan);
        void performSearchIdMember(String nomorKtpMember);
        void performSearchIdNapi(String nomorTahanan);
        
       
    }
}
