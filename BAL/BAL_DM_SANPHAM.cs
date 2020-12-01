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
    public class BAL_DM_SANPHAM
    {
        public DataTable LayDSSP()
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.Read("Sanpham a, Nhacungcap b");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSSPTM(string masp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.LayDSSPTM(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSSPTT(string tensp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.LayDSSPTT(tensp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
   

        public DataTable LayDSNCC()
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.LayDS("Nhacungcap");
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayMaNCC(string tenncc)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.LayMaNCC(tenncc);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool KiemTraTonTai(string masp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.KiemTraTonTai(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool ThemSP(BEL_DM_SANPHAM sp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.Them(sp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool XoaSP(string masp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.Xoa(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool CapNhatSP(BEL_DM_SANPHAM sp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.CapNhat(sp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable TimSPBH(string mansx, string tensp)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.TimSPBH(mansx, tensp);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable HienGioHang(BEL_DM_SANPHAM sp, int soluong)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.HienGioHang(sp, soluong);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool UpdateSL(BEL_DM_CHITIETHD cthd)
        {
            try
            {
                DAL_DM_SANPHAM objdal = new DAL_DM_SANPHAM();
                return objdal.UpdateSL(cthd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
