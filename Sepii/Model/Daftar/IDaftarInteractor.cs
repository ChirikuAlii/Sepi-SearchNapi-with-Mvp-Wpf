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
        //make data model in presenter and logic in interactor(less code , less cleaner than another method)
        void Daftar(MemberModel memberModel, IOnDaftarFinishedListener listener);

       
            
            
    }
    interface IOnDaftarFinishedListener
    {
        void onSuccesInsertData();
        void onErrorInsertData();
        void onEmptyInsertData();
    }
}
