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
    public class DAL_DM_KH:General
    {
        public DataTable LayDSKH(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin khach hang
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Makhachhang N'Mã KH', Tenkhachhang N'Tên KH', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'Số điện thoại' from " + table + " where Trangthai = 1", con);

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

        public bool KiemTraTonTai(string makh)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from khachhang where Makhachhang='" + makh + "'", con);
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

        public bool Them(BEL_DM_KH kh)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Khachhang(Makhachhang, Tenkhachhang, Gioitinh, Ngaysinh, Diachi, Sodienthoai, Trangthai) values ('" + kh.Makhachhang+ "',N'" + kh.Tenkhachhang + "',N'" + kh.Gioitinh + "','" + kh.Ngaysinh + "',N'" + kh.Diachi + "','" + kh.Sdt + "',1)";
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

        public bool CapNhat(BEL_DM_KH kh)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Khachhang set makhachhang = '" + kh.Makhachhang + "', tenkhachhang =N'" + kh.Tenkhachhang + "', gioitinh =N'" + kh.Gioitinh + "', Ngaysinh='" + kh.Ngaysinh + "', Diachi=N'" + kh.Diachi + "', Sodienthoai='" + kh.Sdt + "' where Makhachhang = '" + kh.Makhachhang + "'";
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

        public bool XoaKH(string makh)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Khachhang set trangthai =0  where Makhachhang = '" + makh + "'";
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

        public DataTable TimTheoSDT(string sdt)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Makhachhang N'Mã KH', Tenkhachhang N'Tên KH', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'Số điện thoại' from khachhang where Trangthai = 1 and Sodienthoai like '%" + sdt + "%'", con);

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

        public DataTable TimTheoTen(string tenkh)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Makhachhang N'Mã KH', Tenkhachhang N'Tên KH', Gioitinh N'Giới tính', Ngaysinh N'Ngày sinh', Diachi N'Địa chỉ', Sodienthoai N'Số điện thoại' from khachhang where Trangthai = 1 and Tenkhachhang like N'%" + tenkh + "%'", con);

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
