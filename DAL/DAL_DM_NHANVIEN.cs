using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DM_NHANVIEN:General
    {
        public DataTable LayDSNV(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin nhan vien
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Manhanvien N'Mã nhân viên', Hoten N'Họ tên', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'SĐT', Chucvu N'Chức vụ' from "+table+" where Trangthai = 1", con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }

        //public DataTable LayDSCV(string table) //Hien thi danh sach chuc vu len comboxbox
        //{
        //    DataTable dt = new DataTable();
        //    if (ConnectionState.Closed == con.State)
        //        con.Open();

        //    SqlCommand cmd = new SqlCommand("Select Chucvu from " + table, con);

        //    try
        //    {
        //        SqlDataReader rd = cmd.ExecuteReader();

        //        dt.Load(rd);

        //        return dt;
        //    }

        //    catch
        //    {
        //        throw;
        //    }
        //}

        public bool KiemTraTonTai(string manv)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Nhanvien where Manhanvien='" + manv + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }

        public bool Them(BEL_DM_NHANVIEN nv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Nhanvien(Manhanvien, Hoten, Gioitinh, Ngaysinh, Diachi, Sodienthoai, Trangthai, Chucvu) values ('" + nv.Manv + "',N'" + nv.Hoten + "',N'" + nv.Gioitinh + "','" + nv.Ngaysinh + "',N'" + nv.Diachi + "','" + nv.Sodienthoai + "',1,N'" + nv.Chucvu + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }

        public bool CapNhat(BEL_DM_NHANVIEN nv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Nhanvien SET Hoten=N'" + nv.Hoten + "',Gioitinh=N'" + nv.Gioitinh + "',Ngaysinh='" + nv.Ngaysinh+ "',Diachi=N'" + nv.Diachi + "',Sodienthoai='" + nv.Sodienthoai + "',Trangthai = 1, Chucvu = N'"+nv.Chucvu+"' where Manhanvien='" + nv.Manv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }

        public bool Xoa(string manv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Nhanvien set Trangthai = 0 where Manhanvien= '" + manv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }

        public DataTable LayDSNVTM(string manv)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Manhanvien N'Mã nhân viên', Hoten N'Họ tên', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'SĐT', Chucvu N'Chức vụ' from Nhanvien where Trangthai=1 and Manhanvien like '%" + manv + "%'", con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public DataTable LayDSNVTT(string tennv)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Manhanvien N'Mã nhân viên', Hoten N'Họ tên', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'SĐT', Chucvu N'Chức vụ' from Nhanvien where Trangthai=1 and hoten like N'%" + tennv + "%'", con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public string LayHoTen(string us)
        {
            DataTable dt = new DataTable();
            string hoten = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Hoten from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    hoten = dt.Rows[0]["Hoten"].ToString();
                return hoten;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LaySDT(string us)
        {
            DataTable dt = new DataTable();
            string sdt = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Sodienthoai from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    sdt = dt.Rows[0]["Sodienthoai"].ToString();
                return sdt;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayChucVu(string us)
        {
            DataTable dt = new DataTable();
            string Chucvu = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Chucvu from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    Chucvu = dt.Rows[0]["Chucvu"].ToString();
                return Chucvu;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayNgaySinh(string us)
        {
            DataTable dt = new DataTable();
            string ngaysinh = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Ngaysinh from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    ngaysinh = dt.Rows[0]["Ngaysinh"].ToString();
                return ngaysinh;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayGioiTinh(string us)
        {
            DataTable dt = new DataTable();
            string gt = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Gioitinh from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    gt = dt.Rows[0]["Gioitinh"].ToString();
                return gt;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayDiaChi(string us)
        {
            DataTable dt = new DataTable();
            string dc = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Diachi from Nhanvien where Manhanvien=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    dc = dt.Rows[0]["Diachi"].ToString();
                return dc;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable HienThiMaNV(string table) //Hien thi danh sach NCC len cbo
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select Manhanvien from " + table, con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }
    }
}
