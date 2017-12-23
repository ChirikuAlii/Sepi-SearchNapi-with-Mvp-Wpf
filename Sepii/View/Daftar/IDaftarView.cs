using Sepii.Model.LoginPengunjung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.View
{
    interface IDaftarView
    {
        void setValidationsInsertData();
        void setInsertDataSuccess();
        void setInsertDataError();
        void setEmptyInsertData();
        
    }
}
