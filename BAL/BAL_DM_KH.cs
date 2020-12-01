using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;

namespace BAL
{
    public class BAL_DM_KH
    {
        public DataTable LayDSKH()
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.LayDSKH("Khachhang");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool KiemTraTonTai(string makh)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.KiemTraTonTai(makh);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool ThemKH(BEL_DM_KH kh)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.Them(kh);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool CapNhat(BEL_DM_KH kh)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.CapNhat(kh);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool XoaKH(string makh)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.XoaKH(makh);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable TimTheoSDT(string sdt)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.TimTheoSDT(sdt);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable TimTheoTen(string tenkh)
        {
            try
            {
                DAL_DM_KH objdal = new DAL_DM_KH();
                return objdal.TimTheoTen(tenkh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
