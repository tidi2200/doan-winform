using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static string us = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            {
                us = txtTaiKhoan.Text;
                string pw = txtMatKhau.Text;
                BAL_DM_USER xulyuser = new BAL_DM_USER();
                if (xulyuser.KiemTraTrangThai(us))
                {
                    if (xulyuser.login(us, pw))
                    {
                        frmHome home = new frmHome();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Sai UserName hoặc PassWord");
                }
                else
                {
                    MessageBox.Show("Tài khoản của bị đã bị khóa. Hãy liên hệ người quản lý", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án Lập trình WinForm \n- Đức Dương - Tấn Đạt - Quốc Bảo - ", "Thông báo");
            this.Close();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(this, new EventArgs ());
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
            if(e.KeyCode==Keys.Escape)
            {
                btnThoat.PerformClick();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
