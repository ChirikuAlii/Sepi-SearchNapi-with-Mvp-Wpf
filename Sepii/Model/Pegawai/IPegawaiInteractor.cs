using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Presenter.Pegawai;

namespace Sepii.Model.Pegawai
{
    interface IPegawaiInteractor
    {
      
        void LoadData(IOnPegawaiFinishedListener listener);
    }

    interface IOnPegawaiFinishedListener
    {
        void onSuccessLoadData(DataTable data);
        void onErrorLoadData();
    }
}
