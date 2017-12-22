using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Model.LoginPengunjung
{


    public class MemberModel
    {
        String nomorKtp;
        String nama;
        String jenisKelamin;
        String tanggalLahir;
        String agama;
        String kewarganegaraan;
        String nomorTlp;
        String email;
        String alamat;
        String kecamatan;
        String rtRw;

        public String getNomorKtp()
        {
            return nomorKtp;
        }

        public void setNomorKtp(String nomorKtp)
        {
            this.nomorKtp = nomorKtp;
        }

        public String getNama()
        {
            return nama;
        }

        public void setNama(String nama)
        {
            this.nama = nama;
        }

        public String getJenisKelamin()
        {
            return jenisKelamin;
        }

        public void setJenisKelamin(String jenisKelamin)
        {
            this.jenisKelamin = jenisKelamin;
        }

        public String getTanggalLahir()
        {
            return tanggalLahir;
        }

        public void setTanggalLahir(String tanggalLahir)
        {
            this.tanggalLahir = tanggalLahir;
        }

        public String getAgama()
        {
            return agama;
        }

        public void setAgama(String agama)
        {
            this.agama = agama;
        }

        public String getKewarganegaraan()
        {
            return kewarganegaraan;
        }

        public void setKewarganegaraan(String kewarganegaraan)
        {
            this.kewarganegaraan = kewarganegaraan;
        }

        public String getNomorTlp()
        {
            return nomorTlp;
        }

        public void setNomorTlp(String nomorTlp)
        {
            this.nomorTlp = nomorTlp;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getAlamat()
        {
            return alamat;
        }

        public void setAlamat(String alamat)
        {
            this.alamat = alamat;
        }

        public String getKecamatan()
        {
            return kecamatan;
        }

        public void setKecamatan(String kecamatan)
        {
            this.kecamatan = kecamatan;
        }

        public String getRtRw()
        {
            return rtRw;
        }

        public void setRtRw(String rtRw)
        {
            this.rtRw = rtRw;
        }
    }
}
