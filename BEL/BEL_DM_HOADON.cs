using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_HOADON
    {
        string _mahd;

        public string Mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        string _manv;

        public string Manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        string _makh;

        public string Makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        string _ngaylap;

        public string Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }
        string _tongtien;

        public string Tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public BEL_DM_HOADON()
        {
            this._mahd = null;
            this._manv = null;
            this._makh = null;
            this._ngaylap = null;
            this._tongtien = null;
        }

        public BEL_DM_HOADON(string masp, string tensp, string dongia, string soluong, string mancc, string hinhanh)
        {
            this._mahd = masp;
            this._manv = tensp;
            this._makh = dongia;
            this._ngaylap = soluong;
            this._tongtien = mancc;
        }
    }
}
