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
    public class BAL_DM_HOADON
    {
        public DataTable LayDSHD()
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayDSHD("Hoadon");
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraTonTai(string mahd)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.KiemTraTonTai(mahd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaHD(string mahd)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.Xoa(mahd);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSHDTMHD(string mahd)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayDSHDTMHD(mahd);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSHDTMNV(string manv)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayDSHDTMNV(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDSHDTMKH(string makh)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayDSHDTMKH(makh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemHD(BEL_DM_HOADON hd)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.ThemHD(hd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayNgayLap(string us)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayNgayLap(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTongTien(string us)
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.LayTongTien(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }


        public DataTable HienThiMaHD()
        {
            try
            {
                DAL_DM_HOADON objdal = new DAL_DM_HOADON();
                return objdal.HienThiMaHD("Hoa don");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        //public DataTable TimHD(string mahoadon, string manhanvien, string makhachhang)
        //{
        //    try
        //    {
        //        DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
        //        return objdal.TimHD(mahoadon, manhanvien, makhachhang);
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //}

    }
}
