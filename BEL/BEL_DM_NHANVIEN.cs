using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_NHANVIEN
    {
        string _manv;

        public string Manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        string _hoten;

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
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
        string _sodienthoai;

        public string Sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
        string _chucvu;

        public string Chucvu
        {
            get { return _chucvu; }
            set { _chucvu = value; }
        }

        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public BEL_DM_NHANVIEN()
        {
            this._manv = null;
             this._hoten = null;
             this._gioitinh = null;
             this._ngaysinh = null;
             this._diachi = null;
             this._sodienthoai = null;
             this._chucvu = null;
        }

        public BEL_DM_NHANVIEN(string manv, string hoten, string gioitinh, string ngaysinh, string diachi, string sdt, string chucvu)
        {
            this._manv = manv;
            this._hoten = hoten;
            this._gioitinh = gioitinh;
            this._ngaysinh = ngaysinh;
            this._diachi = diachi;
            this._sodienthoai = sdt;
            this._chucvu = chucvu;
        }
    }
}
