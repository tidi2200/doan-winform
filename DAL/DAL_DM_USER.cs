using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class DAL_DM_USER:General
    {
        public bool login(string username, string password)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password); //dua pw vao 1 mang kieu byte
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); // luu mat khau da ma hoa 

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            } //mã hóa mật khẩu


            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Nhanvien where Manhanvien='" + username + "' AND Password='" + hasPass + "'", con);
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

        public bool KiemTraTrung(string us, string pw)
        {
            DataTable dt = new DataTable();
            bool kq = false;

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pw); //dua pw vao 1 mang kieu byte
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); // luu mat khau da ma hoa 

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            } //mã hóa mật khẩu
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Nhanvien where password='" + hasPass + "' and Manhanvien='" + us +"'", con);
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

        public bool DoiMatKhau(string us, string pw)
        {
            bool kq = false;

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pw); //dua pw vao 1 mang kieu byte
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); // luu mat khau da ma hoa 

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            } //mã hóa mật khẩu
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Nhanvien SET password='" + hasPass + "' where Manhanvien='" + us + "'";
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

        public bool TaoTaiKhoan(BEL_DM_NHANVIEN nv)
        {
            bool kq = false;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(nv.Password); //dua pw vao 1 mang kieu byte
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); // luu mat khau da ma hoa 

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            } //mã hóa mật khẩu
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Nhanvien(Manhanvien, password, hoten, chucvu, trangthai, quyen) values('"+nv.Manv+"','"+hasPass+"','"+nv.Hoten+"',N'Nhân viên',1,0)";
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
        public bool MoTK(string us)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Nhanvien set Trangthai = 1 where Manhanvien= '" + us + "'";
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
        public bool KiemTraTrangThai(string us)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from nhanvien where Manhanvien='" + us + "' and trangthai = 1", con);
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
    }
}
