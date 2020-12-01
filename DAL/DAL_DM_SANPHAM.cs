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
    public class DAL_DM_SANPHAM:General
    {
        public DataTable Read(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select Masanpham N'Mã sản phẩm', Tensanpham N'Tên sản phẩm', Dongia N'Đơn giá', Soluong N'Số lượng tồn', TenNCC N'Tên nhà cung cấp', Hinhanh Image from " + table + " where a.MaNCC=b.MaNCC and Trangthai=1", con); 

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

        public DataTable LayDS(string table) //Hien thi danh sach NCC len cbo
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select TenNCC from " + table, con);

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

        public DataTable LayDSSPTM(string masp)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select Masanpham N'Mã sản phẩm', Tensanpham N'Tên sản phẩm', Dongia N'Đơn giá', Soluong N'Số lượng tồn', TenNCC N'Tên nhà cung cấp', Hinhanh Image from Sanpham a, Nhacungcap b where a.MaNCC=b.MaNCC and Trangthai=1 and Masanpham like '%"+ masp + "%'", con);

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

        public DataTable LayDSSPTT(string tensp)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select Masanpham N'Mã sản phẩm', Tensanpham N'Tên sản phẩm', Dongia N'Đơn giá', Soluong N'Số lượng tồn', TenNCC N'Tên nhà cung cấp', Hinhanh Image from Sanpham a, Nhacungcap b where a.MaNCC=b.MaNCC and Trangthai=1 and Tensanpham like '%" + tensp + "%'", con);

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


        public string LayMaNCC(string tenncc)
        {
            DataTable dt = new DataTable();
            string mancc = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select MaNCC from Nhacungcap where TenNCC=N'" + tenncc + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    mancc = dt.Rows[0]["mancc"].ToString();
                return mancc;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraTonTai(string masp)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Sanpham where Masanpham='" + masp + "'", con);
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

        public bool Them(BEL_DM_SANPHAM sp)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Sanpham(Masanpham, Tensanpham, Dongia, Soluong, Trangthai, MaNCC, Hinhanh) values ('" + sp.Masp + "',N'" + sp.Tensp + "',N'" + sp.Dongia + "','" + sp.Soluong + "',1,'" + sp.Mancc + "','..\\..\\product\\" + sp.Hinhanh + "')"; 
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

        public bool Xoa(string masp)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Sanpham set Trangthai = 0 where Masanpham= '" + masp + "'";
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

        public bool CapNhat(BEL_DM_SANPHAM sp)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Sanpham SET Tensanpham=N'" + sp.Tensp + "',Dongia='" + sp.Dongia + "',Soluong='" + sp.Soluong + "',MaNCC='" + sp.Mancc + "',Hinhanh='..\\..\\product\\" + sp.Hinhanh + "' where Masanpham='" + sp.Masp + "'";
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

        public DataTable TimSPBH(string mansx, string tensp)
        {
            DataTable dt = new DataTable(); 
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select Masanpham N'Mã sản phẩm', Tensanpham N'Tên sản phẩm', Dongia N'Đơn giá', Soluong N'Số lượng tồn', TenNCC N'Tên nhà cung cấp' from Sanpham A, Nhacungcap B where a.MaNCC = b.MaNCC and b.MaNCC= '"+mansx+"' and Trangthai=1 and Tensanpham like N'%" + tensp + "%'", con); 

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

        public DataTable HienGioHang(BEL_DM_SANPHAM sp, int soluong)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin san pham
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select Masanpham N'Mã sản phẩm', Tensanpham N'Tên sản phẩm', N'Số lượng'="+soluong+",Dongia*"+soluong+" N'Tổng tiền', TenNCC N'Hãng' from sanpham a, nhacungcap b where a.MaNCC = b.MaNCC and Masanpham = '"+sp.Masp+"'", con);

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

        public bool UpdateSL(BEL_DM_CHITIETHD cthd)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE Sanpham SET Soluong = Soluong - " + cthd.Soluong + " where Masanpham = '" + cthd.Masp + "'";
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
    }
}
