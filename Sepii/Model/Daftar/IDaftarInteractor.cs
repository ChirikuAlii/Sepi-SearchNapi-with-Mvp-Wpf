using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;

namespace Sepii.Model.Daftar
{
    interface IDaftarInteractor
    {
        void Daftar(MemberModel memberModel, IOnDaftarFinishedListener listener);
    }
    interface IOnDaftarFinishedListener
    {
        void onSuccesInsertData();
        void onErrorInsertData();
        void onEmptyInsertData();
    }
}
