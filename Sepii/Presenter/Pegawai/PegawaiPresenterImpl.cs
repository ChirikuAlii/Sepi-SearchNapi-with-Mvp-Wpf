using Sepii.Model.Pegawai;
using Sepii.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Presenter.Pegawai
{
    class PegawaiPresenterImpl : IPegawaiPresenter , IOnPegawaiFinishedListener
    {
        IPegawaiInteractor pegawaiInteractor = new PegawaiInteractorImpl();
        IPegawaiView pegawaiView;
        
       
        public PegawaiPresenterImpl(IPegawaiView view)
        {
            this.pegawaiView = view;
        }

        public void performLoadTable()
        {
            pegawaiInteractor.LoadData(this);
        }




        public void onErrorLoadData()
        {
            pegawaiView.setErrorLoadTable();
        }

       

        public void onSuccessLoadData(DataTable data)
        {
            pegawaiView.setSucccesLoadTable(data);
        }

      
    }
}
