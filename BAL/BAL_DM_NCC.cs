using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class BAL_DM_NCC
    {
        public DataTable LayDSNCC()
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.Read("Nhacungcap a, Sanpham b");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool KiemTraTonTai(string mancc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.KiemTraTonTai(mancc);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public bool XoaNCC(string mancc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.Xoa(mancc);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemNCC(BEL_DM_NCC ncc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.Them(ncc);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public bool CapNhat(BEL_DM_NCC ncc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.CapNhat(ncc);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSNCCTMNCC(string mancc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.LayDSNCCTMNCC(mancc);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public DataTable LayDSNCCTTNCC(string tenncc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.LayDSNCCTTNCC(tenncc);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public string LayMaSP(string mancc)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.LayMaSP(mancc);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public string LayDiaChi(string us)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.LayDiaChi(us);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public string LaySDT(string us)
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.LaySDT(us);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public DataTable HienThiMaNCC()
        {
            try
            {
                DAL_DM_NCC objdal = new DAL_DM_NCC();
                return objdal.HienThiMaNCC("Nhacungcap");
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
