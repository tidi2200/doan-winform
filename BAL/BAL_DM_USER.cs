using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace BAL
{
    public class BAL_DM_USER
    {
        public bool login(string username, string password)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.login(username, password);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool KiemTraTrung(string us, string pw)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.KiemTraTrung(us, pw);
            }
            catch(Exception err)
            {
                throw;
            }
        }

        public bool DoiMatKhau(string us, string pw)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.DoiMatKhau(us, pw);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool TaoTaiKhoan(BEL_DM_NHANVIEN nv)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.TaoTaiKhoan(nv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool MoTK(string us)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.MoTK(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraTrangThai(string us)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.KiemTraTrangThai(us);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
