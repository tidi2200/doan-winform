using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_KH
    {
        string _makhachhang;

        public string Makhachhang
        {
            get { return _makhachhang; }
            set { _makhachhang = value; }
        }
        string _tenkhachhang;

        public string Tenkhachhang
        {
            get { return _tenkhachhang; }
            set { _tenkhachhang = value; }
        }
        string _gioitinh;

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        string _ngaysinh;

        public string Ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public BEL_DM_KH()
        {
            this._makhachhang = null;
            this._tenkhachhang = null;
            this._gioitinh = null;
            this._ngaysinh = null;
            this._diachi = null;
            this._sdt = null;
        }

        public BEL_DM_KH(string makh, string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt)
        {
            this._makhachhang = makh;
            this._tenkhachhang = tenkh;
            this._gioitinh = gioitinh;
            this._ngaysinh = ngaysinh;
            this._diachi = diachi;
            this._sdt = sdt;
        }
    }
}
