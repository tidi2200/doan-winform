using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace DoAn
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private string us = frmDangNhap.us;
        private void TrangChu_Load(object sender, EventArgs e)
        {
            HienThiHoTen(lblHoTen);
            lblTaiKhoan.Text = us;
            HienThiSoDienThoai(lblSDT);
            HienThiChucVu(lblChucVu);
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            string chucvu = xulynhanvien.LayChucVu(us);
            if (chucvu == "Nhân viên")
            {
                btnQuanLyTK.Enabled = false;
            }
        }

        public void HienThiHoTen(Label lbl)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            lbl.Text = xulynhanvien.LayHoTen(us);
        }

        public void HienThiSoDienThoai(Label lbl)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            lbl.Text = xulynhanvien.LaySDT(us);
        }

        public void HienThiChucVu(Label lbl)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            lbl.Text = xulynhanvien.LayChucVu(us);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //frmHome home = new frmHome();
           // home.Close();
            this.Hide();
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            frmDoiThongTin change = new frmDoiThongTin();
            change.ShowDialog();
            this.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau changepw = new frmDoiMatKhau();
            changepw.ShowDialog();
            this.Show();
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan manage = new frmQuanLyTaiKhoan();
            manage.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
