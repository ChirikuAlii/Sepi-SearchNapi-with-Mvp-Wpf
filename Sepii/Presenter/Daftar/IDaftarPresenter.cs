using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;
namespace Sepii.Presenter.Daftar
{
    interface IDaftarPresenter
    {
        void perfromAddData(
        String nomorKtp,
        String nama,
        String jenisKelamin,
        String tanggalLahir,
        String agama,
        String kewarganegaraan,
        String nomorTlp,
        String email,
        String alamat,
        String kecamatan,
        String rtRw
            );
    }
}
