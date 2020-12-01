using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_DM_CHITIETHD:General
    {
        public bool Them(BEL_DM_CHITIETHD cthd)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into Chitiethoadon(Masanpham, Tensanpham, Dongia, Soluong, Chietkhau, Thanhtien) values ('" + cthd.Masp + "',N'" + cthd.Tensp + "','" + cthd.Dongia + "','" + cthd.Soluong + "','"+cthd.Chietkhau+"','"+cthd.Thanhtien+"')";
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
