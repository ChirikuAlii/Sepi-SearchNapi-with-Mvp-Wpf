using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;
using Sepii.Model.Daftar;
using Sepii.View;

namespace Sepii.Presenter.Daftar
{
    class DaftarPresenterImpl : IDaftarPresenter ,IOnDaftarFinishedListener
    {
        IDaftarView daftarView;
        IDaftarInteractor daftarInteractor = new DaftarInteractorImpl();
        MemberModel dataModel = new MemberModel();

        public DaftarPresenterImpl(IDaftarView view)
        {
            this.daftarView = view;
        }

        public void perfromAddData(
            string nomorKtp, 
            string nama, 
            string jenisKelamin, 
            string tanggalLahir, 
            string agama, 
            string kewarganegaraan, 
            string nomorTlp, 
            string email, 
            string alamat, 
            string kecamatan, 
            string rtRw)
        {
            dataModel.setNomorKtp(nomorKtp);
            dataModel.setNama(nama);
            dataModel.setJenisKelamin(jenisKelamin);
            dataModel.setTanggalLahir(tanggalLahir);
            dataModel.setAgama(agama);
            dataModel.setKewarganegaraan(kewarganegaraan);
            dataModel.setNomorTlp(nomorTlp);
            dataModel.setEmail(email);
            dataModel.setAlamat(alamat);
            dataModel.setKecamatan(kecamatan);
            dataModel.setRtRw(rtRw);


            daftarInteractor.Daftar(dataModel, this);
        }

        public void onErrorInsertData()
        {
            daftarView.setInsertDataError();
        }

        public void onSuccesInsertData()
        {
            daftarView.setInsertDataSuccess();
            
        }

        public void onEmptyInsertData()
        {
            daftarView.setEmptyInsertData();
        }
    }
}
