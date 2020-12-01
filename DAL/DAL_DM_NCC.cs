using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;

namespace DAL
{
    public class DAL_DM_NCC : General
    {
        public DataTable Read(string table)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select distinct a.MaNCC N'Mã NCC', TenNCC N'Tên NCC', Diachi N'Địa chỉ',Sdt N'Số điện thoại' from Nhacungcap a, Sanpham b", con);

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

        public bool KiemTraTonTai(string mancc)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Nhacungcap where MaNCC='" + mancc + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    kq = true;
            }
            catch (Exception Err)
            {
                throw;
            }
            return kq;

        }

        public bool Xoa(string mancc)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "delete from Nhacungcap where mancc =N'" + mancc + "'";
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

        public bool CapNhat(BEL_DM_NCC ncc)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Nhacungcap SET MaNCC = N'" + ncc.Mancc + "', TenNCC =N'" + ncc.Tenncc + "', Diachi =N'" + ncc.Diachi + "', Sdt=N'" + ncc.Sdt + "' where MaNCC = '" + ncc.Mancc + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
            }
            return kq;
        }
        public bool Them(BEL_DM_NCC ncc)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Nhacungcap(MaNCC, TenNCC, Diachi, Sdt) values (N'" + ncc.Mancc + "',N'" + ncc.Tenncc + "',N'" + ncc.Diachi + "',N'" + ncc.Sdt + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
            }
            return kq;
        }
        public DataTable LayDSNCCTMNCC(string mancc)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select MaNCC N'Mã NCC', TenNCC N'Tên NCC', Diachi N'Địa chỉ', Sdt N'Số điện thoại' from Nhacungcap where MaNCC  like '%" + mancc + "%'", con);

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

        public DataTable LayDSNCCTTNCC(string tenncc)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select MaNCC N'Mã NCC', TenNCC N'Tên NCC', Diachi N'Địa chỉ', Sdt N'Số điện thoại' from Nhacungcap a where TenNCC  like '%" + tenncc + "%'", con);

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

        public string LayDiaChi(string us)
        {
            DataTable dt = new DataTable();
            string diachi = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Diachi from Nhacungcap where MaNCC=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    diachi = dt.Rows[0]["DiaChi"].ToString();
                return diachi;
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
            SqlCommand cmd = new SqlCommand("select Sdt from Nhacungcap where MaNCC=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    sdt = dt.Rows[0]["SoDienThoai"].ToString();
                return sdt;
            }
            catch (Exception err)
            {
                throw;
            }
        }



        public DataTable HienThiMaNCC(string table)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select MaNCC from " + table, con);

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

        //public string LayTenNCC(string us)
        //{
        //    DataTable dt = new DataTable();
        //    string tenncc = null;
        //    if (ConnectionState.Closed == con.State)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand("select TenNCC from Nhacungcap where MaNCC=N'" + us + "'", con);
        //    try
        //    {
        //        SqlDataReader rd = cmd.ExecuteReader();
        //        dt.Load(rd);
        //        if (dt.Rows.Count > 0)
        //            tenncc = dt.Rows[0]["TenNCC"].ToString();
        //        return tenncc;
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //}

        public string LayMaSP(string us)
        {
            DataTable dt = new DataTable();
            string mancc = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Masanpham from Sanpham where MaNCC=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    mancc = dt.Rows[0]["MaNCC"].ToString();
                return mancc;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
