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

    public class DAL_DM_HOADON : General
    {
        public bool ThemHD(BEL_DM_HOADON hd)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Hoadon(Manhanvien, Makhachhang, Ngaylap, Tongtien, Trangthai) values ('" + hd.Manv + "','" + hd.Makh + "','" + hd.Ngaylap + "','" + hd.Tongtien + "',1)";
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
        public DataTable LayDSHD(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin hoa don
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Mahoadon N'Mã hóa đơn', Manhanvien N'Mã nhân viên', Makhachhang N'Mã khách hàng', Ngaylap N'Ngày lập', Tongtien N'Tổng tiền' from " + table + " where Trangthai = 1", con);

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

        public bool KiemTraTonTai(string mahd)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Hoadon where Mahoadon='" + mahd + "'", con);
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
        public bool Xoa(string mahd)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Hoadon set Trangthai = 0 where Mahoadon= '" + mahd + "'";
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

        public DataTable LayDSHDTMHD(string mahd)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Mahoadon N'Mã hóa đơn', Manhanvien N'Mã nhân viên',Makhachhang N'Mã khách hàng', Ngaylap N'Ngày lập', Tongtien N'Tổng tiền' from Hoadon where Trangthai=1 and Mahoadon like '%" + mahd + "%'", con);

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

        public DataTable LayDSHDTMNV(string manv)
        {
            DataTable dt = new DataTable(); 
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Mahoadon N'Mã hóa đơn', Manhanvien N'Mã nhân viên',Makhachhang N'Mã khách hàng', Ngaylap N'Ngày lập', Tongtien N'Tổng tiền' from Hoadon where Trangthai=1 and Manhanvien like '%" + manv + "%'", con);

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

        public DataTable LayDSHDTMKH(string makh)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Mahoadon N'Mã hóa đơn', Manhanvien N'Mã nhân viên',Makhachhang N'Mã khách hàng', Ngaylap N'Ngày lập', Tongtien N'Tổng tiền' from Hoadon where Trangthai=1 and Makhachhang like '%" + makh + "%'", con);

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

        public string LayNgayLap(string us)
        {
            DataTable dt = new DataTable();
            string ngaylap = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Ngaylap from Hoadon where Mahoadon=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    ngaylap = dt.Rows[0]["NgayLap"].ToString();
                return ngaylap;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public string LayTongTien(string us)
        {
            DataTable dt = new DataTable();
            string tt = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Tongtien from Hoadon where Mahoadon=N'" + us + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    tt = dt.Rows[0]["Tongtien"].ToString();
                return tt;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        //public DataTable TimHD(string mahoadon, string manhanvien, string makhachhang)
        //{
        //    DataTable dt = new DataTable();
        //    if (ConnectionState.Closed == con.State)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand("Select Mahoadon N'Mã hóa đơn', Manhanvien N'Mã nhân viên', Makhachhang N'Mã khách hàng', Ngaylap N'Ngày lập', Tổng tiền N'Tổng tiền' from Hoadon A, Chitiethoadon B where a.Mahoadon = b.Mahoadon and a.Mahoadon= '" + mahoadon + "' and Trangthai=1 and a.Manhanvien= '" + manhanvien + "'and a.Makhachhang= '" + makhachhang + "'", con);

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

        public DataTable HienThiMaHD(string table) //Hien thi danh sach NCC len cbo
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select Mahoadon from " + table, con);

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
