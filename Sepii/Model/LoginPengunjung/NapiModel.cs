using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Model.LoginPengunjung
{
   public class NapiModel
    {

        String nomorTahanan;
        String namaTahanan;
        String jenisKelaminTahanan;
        String tanggalLahirTahanan;
        String agamaTahanan;
        String kewarganegaraanTahanan;


        public String getNomorTahanan()
        {
            return nomorTahanan;
        }

        public void setNomorTahanan(String nomorTahanan)
        {
            this.nomorTahanan = nomorTahanan;
        }

        public String getNamaTahanan()
        {
            return namaTahanan;
        }

        public void setNamaTahanan(String namaTahanan)
        {
            this.namaTahanan = namaTahanan;
        }

        public String getJenisKelaminTahanan()
        {
            return jenisKelaminTahanan;
        }

        public void setJenisKelaminTahanan(String jenisKelaminTahanan)
        {
            this.jenisKelaminTahanan = jenisKelaminTahanan;
        }

        public String getTanggalLahirTahanan()
        {
            return tanggalLahirTahanan;
        }

        public void setTanggalLahirTahanan(String tanggalLahirTahanan)
        {
            this.tanggalLahirTahanan = tanggalLahirTahanan;
        }

        public String getAgamaTahanan()
        {
            return agamaTahanan;
        }

        public void setAgamaTahanan(String agamaTahanan)
        {
            this.agamaTahanan = agamaTahanan;
        }

        public String getKewarganegaraanTahanan()
        {
            return kewarganegaraanTahanan;
        }

        public void setKewarganegaraanTahanan(String kewarganegaraanTahanan)
        {
            this.kewarganegaraanTahanan = kewarganegaraanTahanan;
        }


    }
}
