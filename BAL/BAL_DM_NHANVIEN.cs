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
    public class BAL_DM_NHANVIEN
    {
        public DataTable LayDSNV()
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayDSNV("Nhanvien");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        //public DataTable LayDSCV()
        //{
        //    try
        //    {
        //        DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
        //        return objdal.LayDSCV("Nhanvien");
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //}

        public bool KiemTraTonTai(string manv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.KiemTraTonTai(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool ThemNV(BEL_DM_NHANVIEN nv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.Them(nv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool CapNhatNV(BEL_DM_NHANVIEN nv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.CapNhat(nv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool XoaNV(string manv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.Xoa(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSNVTM(string manv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayDSNVTM(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSNVTT(string tennv)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayDSNVTT(tennv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayHoTen(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayHoTen(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayDiaChi(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayDiaChi(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LaySDT(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LaySDT(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayChucVu(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayChucVu(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayNgaySinh(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayNgaySinh(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayGioiTinh(string us)
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.LayGioiTinh(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable HienThiMaNV()
        {
            try
            {
                DAL_DM_NHANVIEN objdal = new DAL_DM_NHANVIEN();
                return objdal.HienThiMaNV("Nhanvien");
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
