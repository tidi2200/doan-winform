using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_CHITIETHD
    {
        string _masp;

        public string Masp
        {
            get { return _masp; }
            set { _masp = value; }
        }
        string _tensp;

        public string Tensp
        {
            get { return _tensp; }
            set { _tensp = value; }
        }
        string _dongia;

        public string Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        string _soluong;

        public string Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        string _chietkhau;

        public string Chietkhau
        {
            get { return _chietkhau; }
            set { _chietkhau = value; }
        }
        string _thanhtien;

        public string Thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }

        public BEL_DM_CHITIETHD()
        {
            string _masp = null;
            string _tensp = null;
            string _dongia = null;
            string _soluong = null;
            string _chietkhau = null;
            string _thanhtien = null;
        }

        public BEL_DM_CHITIETHD(string masp, string tensp, string dongia, string soluong, string chietkhau, string thanhtien)
        {
            string _masp = masp;
            string _tensp = tensp;
            string _dongia = dongia;
            string _soluong = soluong;
            string _chietkhau = chietkhau;
            string _thanhtien = thanhtien;
        }
    }
}
