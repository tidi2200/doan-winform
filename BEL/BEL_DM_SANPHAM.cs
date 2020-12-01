using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_SANPHAM
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
        string _mancc;

        public string Mancc
        {
            get { return _mancc; }
            set { _mancc = value; }
        }

        string _hinhanh;

        public string Hinhanh
        {
            get { return _hinhanh; }
            set { _hinhanh = value; }
        }

        public BEL_DM_SANPHAM()
        {
            this._masp = null;
            this._tensp = null;
            this._dongia = null;
            this._soluong = null;
            this._mancc = null;
            this._hinhanh = null;
        }

        public BEL_DM_SANPHAM(string masp, string tensp, string dongia, string soluong, string mancc, string hinhanh)
        {
            this._masp = masp;
            this._tensp = tensp;
            this._dongia = dongia;
            this._soluong = soluong;
            this._mancc = mancc;
            this._hinhanh = hinhanh;
        }
    }
}
