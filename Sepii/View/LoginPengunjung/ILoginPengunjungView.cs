using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;


namespace Sepii.View
{
    interface ILoginPengunjungView
    {
        void setAddDataSuccess();
        void setAddDataError();
        void setItemMemberr( MemberModel dataModel);
        void setItemNapi(NapiModel dataModel);
        void setErrorItemMember();
        void setErrorItemNapi();
        
    }
}
