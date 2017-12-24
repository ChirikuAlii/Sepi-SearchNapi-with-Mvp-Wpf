using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.View
{
    interface IPegawaiView
    {
       
        void setErrorLoadTable();
        void setSucccesLoadTable(DataTable dataAntri);
    }
}
