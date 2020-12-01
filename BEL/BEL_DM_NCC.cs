using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_NCC
    {
        string _mancc;

        public string Mancc
        {
            get { return _mancc; }
            set { _mancc = value; }
        }

        string _tenncc;

        public string Tenncc
        {
            get { return _tenncc; }
            set { _tenncc = value; }
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

        public BEL_DM_NCC()
        {
            this._mancc = null;
            this._tenncc = null;
            this._diachi = null;
            this._sdt = null;
        }

        public BEL_DM_NCC(string mancc, string tenncc, string diachi, string sdt)
        {
            this._mancc = mancc;
            this._tenncc = tenncc;
            this._diachi = diachi;
            this._sdt = sdt;
        }
    }
}
