using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mppl.Entitas
{
    public class Hasil
    {
        private string judul;

        public string Judul
        {
            get { return judul; }
            set { judul = value; }
        }
        private string urlAsal;

        public string UrlAsal
        {
            get { return urlAsal; }
            set { urlAsal = value; }
        }
        private double persentase;

        public double Persentase
        {
            get { return persentase; }
            set { persentase = value; }
        }

        public Hasil(string judul,string url,double hasil)
        {
            this.judul = judul;
            this.urlAsal = url;
            this.persentase = hasil;
        }
    }
}